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

        public UserManagement()
        {
            InitializeComponent();
            LoadDataIntoGridView();
        }

        private async Task<List<User>> FetchUsersAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = "http://localhost:8080/admin/users?page=0";
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

        public async void LoadDataIntoGridView()
        {
            // Huỷ đăng ký sự kiện cũ (nếu có)
            dataGridViewUsers.CellClick -= DataGridViewUsers_CellClick;
            List<User> users = await FetchUsersAsync();
            if (users != null)
            {
                // Đặt dữ liệu vào DataGridView
                dataGridViewUsers.DataSource = users;

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

                // Xử lý sự kiện nhấn nút "Sửa" và "Xoá"
                dataGridViewUsers.CellContentClick += (s, e) =>
                {
                    if (e.ColumnIndex == dataGridViewUsers.Columns["Delete"].Index && e.RowIndex >= 0)
                    {
                        // Xoá user logic
                        string userId = dataGridViewUsers.Rows[e.RowIndex].Cells["UserId"].Value.ToString();
                        DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xoá user với ID: {userId}?", "Xoá người dùng", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // Thực hiện gọi API hoặc logic xoá user
                            MessageBox.Show($"Xoá thông tin user với ID: {userId}");
                        }
                    }
                };
                dateTimePickerDob.Format = DateTimePickerFormat.Custom;
                dateTimePickerDob.CustomFormat = " ";
                // Sự kiện khi nhấn vào một dòng trong DataGridView
                dataGridViewUsers.CellClick += DataGridViewUsers_CellClick;
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
                comboBoxGender.Text = selectedUser.Gender == true ? "Nam" : "Nữ";
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

        private void buttonRestore_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonAddUser_Click(object sender, EventArgs e)
        {
            Form addUserForm = new AddUser(this);
            addUserForm.ShowDialog();
        }
    }
}
