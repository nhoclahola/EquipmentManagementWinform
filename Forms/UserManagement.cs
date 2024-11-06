using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EquipmentManagementWinform.Forms.EquipmentManagement;

namespace EquipmentManagementWinform.Forms
{
    public partial class UserManagement : Form
    {
        public class User
        {
            public string UserId { get; set; }
            public string FullName { get; set; }
            public bool? Gender { get; set; } // null = chưa xác định
            public string PhoneNumber { get; set; }
            public DateTime? Dob { get; set; }
            public string Role { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private long currentPageNumber = 1;
        private long totalPageNumber;
        private bool isSearch = false;

        public UserManagement()
        {
            InitializeComponent();
            iconButtonCancelSearch.Visible = false;
            // Tùy chỉnh DataGridView
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.DefaultCellStyle.BackColor = Color.White;
            dataGridViewUsers.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewUsers.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridViewUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Tùy chỉnh tiêu đề cột
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Căn chỉnh dữ liệu
            dataGridViewUsers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Tùy chỉnh đường viền ô
            dataGridViewUsers.GridColor = Color.Black;
            dataGridViewUsers.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewUsers.RowHeadersVisible = false;  // Ẩn tiêu đề hàng

            // Cài đặt tự động điều chỉnh kích thước cột
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đăng ký sự kiện
            dataGridViewUsers.CellContentClick += DataGridViewUsers_CellClickDeleteUser;
            dataGridViewUsers.CellClick += DataGridViewUsers_CellClick;

            LoadDataIntoGridView(currentPageNumber);    // Khởi đầu là 1
        }

        public async Task<long> FetchUsersCountAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = "http://localhost:8080/admin/users/count";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    return long.Parse(countString);
                }

                return 0;
            }
        }

        private async Task<List<User>> FetchUsersAsync(long pageNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = $"http://localhost:8080/admin/users?page={pageNumber}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // Deserialize JSON thành danh sách User
                    List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonResponse);
                    return users;
                }

                return null;
            }
        }

        public async Task<long> FetchSearchUsersCountAsync(string query)
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = $"http://localhost:8080/admin/users/search/count?query={query}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    return long.Parse(countString);
                }

                return 0;
            }
        }

        private async Task<List<User>> FetchSearchUsersAsync(string query, long pageNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = $"http://localhost:8080/admin/users/search?query={query}&page={pageNumber}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // Deserialize JSON thành danh sách User
                    List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonResponse);
                    return users;
                }

                return null;
            }
        }

        private async void deleteUser(long userId)
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = $"http://localhost:8080/admin/users/{userId}";
                HttpResponseMessage response = await client.DeleteAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    long userCount = await FetchUsersCountAsync();
                    long totalPageNumber = (userCount - 1) / 10 + 1;
                    LoadDataIntoGridView(currentPageNumber);
                    labelPageNumber.Text = currentPageNumber.ToString();
                    labelTotalPageNumber.Text = totalPageNumber.ToString();
                    MessageBox.Show($"Đã xoá người dùng có ID: {userId}");
                }
                else
                    MessageBox.Show($"Có lỗi xảy ra khi xoá người dùng với ID: {userId}");
            }
        }

        public async void LoadDataIntoGridView(long pageNumber)
        {
            List<User> users;
            if (!isSearch)
            {
                //Check page
                long userCount = await FetchUsersCountAsync();
                totalPageNumber = (userCount - 1) / 10 + 1;
                labelTotalPageNumber.Text = totalPageNumber.ToString();
                // Xoá toàn bộ cột và dữ liệu hiện tại trong DataGridView
                dataGridViewUsers.Columns.Clear();
                dataGridViewUsers.DataSource = null;
                users = await FetchUsersAsync(pageNumber);
            }
            else
            {
                //Check page
                long userCount = await FetchSearchUsersCountAsync(textBoxSearch.Text);
                totalPageNumber = (userCount - 1) / 10 + 1;
                labelTotalPageNumber.Text = totalPageNumber.ToString();
                // Xoá toàn bộ cột và dữ liệu hiện tại trong DataGridView
                dataGridViewUsers.Columns.Clear();
                dataGridViewUsers.DataSource = null;
                users = await FetchSearchUsersAsync(textBoxSearch.Text, pageNumber);
            }
            if (users != null)
            {
                // Đặt dữ liệu vào DataGridView
                dataGridViewUsers.DataSource = users;


                // Tạo cột "Hành động" với nút "Xoá"
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "Delete";
                deleteColumn.HeaderText = "Xoá";
                deleteColumn.Text = "Xoá";
                deleteColumn.UseColumnTextForButtonValue = true;
                dataGridViewUsers.Columns.Add(deleteColumn);

                // Đổi tên các cột trong DataGridView
                dataGridViewUsers.Columns["UserId"].HeaderText = "ID";
                dataGridViewUsers.Columns["FullName"].HeaderText = "Họ và tên";
                dataGridViewUsers.Columns["Gender"].HeaderText = "Giới tính";
                dataGridViewUsers.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
                dataGridViewUsers.Columns["DoB"].HeaderText = "Ngày sinh";
                dataGridViewUsers.Columns["Role"].HeaderText = "Chức vụ";
                dataGridViewUsers.Columns["Username"].HeaderText = "Username";
                dataGridViewUsers.Columns["Password"].HeaderText = "Mật khẩu";

                // Ẩn các cột không cần thiết
                dataGridViewUsers.Columns["Gender"].Visible = false;
                dataGridViewUsers.Columns["PhoneNumber"].Visible = false;
                dataGridViewUsers.Columns["DoB"].Visible = false;
                dataGridViewUsers.Columns["Role"].Visible = false;
                dataGridViewUsers.Columns["Password"].Visible = false;

                dataGridViewUsers.Columns["UserId"].ReadOnly = true;
                dataGridViewUsers.Columns["FullName"].ReadOnly = true;
                dataGridViewUsers.Columns["Gender"].ReadOnly = true;
                dataGridViewUsers.Columns["PhoneNumber"].ReadOnly = true;
                dataGridViewUsers.Columns["DoB"].ReadOnly = true;
                dataGridViewUsers.Columns["Role"].ReadOnly = true;
                dataGridViewUsers.Columns["Username"].ReadOnly = true;
                dataGridViewUsers.Columns["Password"].ReadOnly = true;

                // Không cho phép thay đổi kích thước cột
                dataGridViewUsers.AllowUserToResizeColumns = false;

                // Không cho phép thay đổi kích thước hàng
                dataGridViewUsers.AllowUserToResizeRows = false;

                dateTimePickerDob.Format = DateTimePickerFormat.Custom;
                dateTimePickerDob.CustomFormat = " ";

                labelPageNumber.Text = pageNumber.ToString();
                labelTotalPageNumber.Text = totalPageNumber.ToString();
            }
            else
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ API.");
            }
        }

        // Đưa sự kiện ra thành một phương thức riêng để có thể tái sử dụng
        private void DataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị của cột "Username" trong dòng được chọn
                User selectedUser = ((List<User>) dataGridViewUsers.DataSource)[e.RowIndex];

                // Đặt giá trị của các control
                textBoxUsername.Text = selectedUser.Username;
                textBoxFullName.Text = selectedUser.FullName;
                if (selectedUser.Gender == null)
                    comboBoxGender.Text = "Khác";
                else if (selectedUser.Gender == true)
                    comboBoxGender.Text = "Nam";
                else if (selectedUser.Gender == false)
                    comboBoxGender.Text = "Nữ";
                textBoxPhoneNumber.Text = selectedUser.PhoneNumber;
                comboBoxRole.Text = selectedUser.Role == "USER" ? "Trợ giảng" : "Quản lý";
                textBoxPassword.Text = selectedUser.Password;

                if (selectedUser.Dob != null)
                {
                    dateTimePickerDob.Value = selectedUser.Dob.Value;
                    dateTimePickerDob.CustomFormat = "dd/MM/yyyy";
                }
                else
                {
                    dateTimePickerDob.CustomFormat = " ";
                }
            }
        }

        // Phương thức xoá
        private void DataGridViewUsers_CellClickDeleteUser(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUsers.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Xoá user logic
                string userId = dataGridViewUsers.Rows[e.RowIndex].Cells["UserId"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xoá user với ID: {userId}?", "Xoá người dùng", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    // Thực hiện gọi API xoá user
                    deleteUser(long.Parse(userId));
            }
        }    

        private void buttonRestore_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonAddUser_Click(object sender, EventArgs e)
        {
            Form addUserForm = new AddUser(this);
            addUserForm.ShowDialog();
        }

        private async void iconButtonNextPage_Click(object sender, EventArgs e)
        {
            //Check page
            currentPageNumber = long.Parse(labelPageNumber.Text);
            if (currentPageNumber < totalPageNumber)
            {
                currentPageNumber += 1;
                labelPageNumber.Text = currentPageNumber.ToString();
                LoadDataIntoGridView(currentPageNumber);
            }
        }

        private async void iconButtonPreviousPage_Click(object sender, EventArgs e)
        {
            //Check page
            currentPageNumber = long.Parse(labelPageNumber.Text);
            if (currentPageNumber > 1)
            {
                currentPageNumber -= 1;
                labelPageNumber.Text = currentPageNumber.ToString();
                LoadDataIntoGridView(currentPageNumber);
            }
        }

        private async void iconButtonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                isSearch = true;
                currentPageNumber = 1;
                iconButtonSearch.Visible = false;
                iconButtonCancelSearch.Visible = true;
                LoadDataIntoGridView(currentPageNumber);
            }    
        }

        private async void iconButtonCancelSearch_Click(object sender, EventArgs e)
        {
            isSearch = false;
            currentPageNumber = 1;
            iconButtonSearch.Visible = true;
            iconButtonCancelSearch.Visible = false;
            LoadDataIntoGridView(currentPageNumber);
        }
    }
}
