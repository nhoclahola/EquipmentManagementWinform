using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EquipmentManagementWinform.Forms.EquipmentManagement;
using static EquipmentManagementWinform.Forms.UserManagement;

namespace EquipmentManagementWinform.Forms
{
    public partial class EquipmentManagement : Form
    {
        public class Room
        {
            public int RoomId { get; set; }
            public string RoomName { get; set; }
        }

        public class Equipment
        {
            public int EquipmentId { get; set; }
            public string EquipmentName { get; set; }
            public string ImageUrl { get; set; }
            public int? TotalQuantity { get; set; }
            public int? RemainQuantity { get; set; }
            public List<Room> Rooms { get; set; }
        }

        private long currentPageNumber = 1;
        private long currentEquipmentId;
        private long totalPageNumber;
        private bool isSearch = false;

        public EquipmentManagement()
        {
            InitializeComponent();
            iconButtonCancelSearch.Visible = false;

            // Tùy chỉnh DataGridView
            dataGridViewEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEquipment.DefaultCellStyle.BackColor = Color.White;
            dataGridViewEquipment.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewEquipment.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridViewEquipment.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Tùy chỉnh tiêu đề cột
            dataGridViewEquipment.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewEquipment.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewEquipment.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewEquipment.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Căn chỉnh dữ liệu
            dataGridViewEquipment.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Tùy chỉnh đường viền ô
            dataGridViewEquipment.GridColor = Color.Black;
            dataGridViewEquipment.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewEquipment.RowHeadersVisible = false;  // Ẩn tiêu đề hàng

            // Cài đặt tự động điều chỉnh kích thước cột
            dataGridViewEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Sự kiện
            dataGridViewEquipment.CellContentClick += DataGridViewEquipments_CellClickDeleteEquipment;
            dataGridViewEquipment.CellClick += DataGridViewEquipments_CellClick;
            LoadDataIntoGridView(currentPageNumber);    // Khởi đầu là 1

        }

        private async void LoadImageFromUrl(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Tải ảnh từ API URL
                    byte[] imageBytes = await client.GetByteArrayAsync(url);

                    // Chuyển đổi byte thành ảnh
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);

                        // Gán ảnh vào PictureBox
                        pictureBoxEquipment.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Có lỗi khi tải ảnh: {ex.Message}");
                pictureBoxEquipment.Image = Properties.Resources.no_image;
            }
        }

        public async Task<long> FetchEquipmentCountAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "http://localhost:8080/admin/equipments/count";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    return long.Parse(countString);
                }

                return 0;
            }
        }

        private async Task<List<Equipment>> FetchEquipmentsAsync(long pageNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"http://localhost:8080/admin/equipments/all-quantities?page={pageNumber}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // Deserialize JSON thành danh sách User
                    List<Equipment> equipments = JsonConvert.DeserializeObject<List<Equipment>>(jsonResponse);
                    return equipments;
                }
                return null;
            }
        }

        public async Task<long> FetchSearchEquipmentCountAsync(string query)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"http://localhost:8080/admin/equipments/search/count?{query}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    return long.Parse(countString);
                }
                return 0;
            }
        }

        private async Task<List<Equipment>> FetchSearchEquipmentsAsync(string query, long pageNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"http://localhost:8080/admin/equipments/search/all-quantities?query={query}&page={pageNumber}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<Equipment> equipments = JsonConvert.DeserializeObject<List<Equipment>>(jsonResponse);
                    return equipments;
                }
                return null;
            }
        }

        private async void deleteEquipment(long equipmentId)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"http://localhost:8080/admin/equipments/{equipmentId}";
                HttpResponseMessage response = await client.DeleteAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    // Trang mới nhất
                    long equipmentCount = await FetchEquipmentCountAsync();
                    long totalPageNumber = (equipmentCount - 1) / 10 + 1;
                    LoadDataIntoGridView(currentPageNumber);
                    labelPageNumber.Text = currentPageNumber.ToString();
                    labelTotalPageNumber.Text = totalPageNumber.ToString();
                    MessageBox.Show($"Đã xoá thiết bị có ID: {equipmentId}");
                }
                else
                    MessageBox.Show($"Có lỗi xảy ra khi xoá người dùng với ID: {equipmentId}");
            }
        }

        public async void LoadDataIntoGridView(long pageNumber)
        {
            List<Equipment> equipments;
            if (!isSearch)
            {
                //Check page
                long equipmentCount = await FetchEquipmentCountAsync();
                totalPageNumber = (equipmentCount - 1) / 10 + 1;
                labelTotalPageNumber.Text = totalPageNumber.ToString();

                // Xoá toàn bộ cột và dữ liệu hiện tại trong DataGridView
                dataGridViewEquipment.Columns.Clear();
                dataGridViewEquipment.DataSource = null;

                equipments = await FetchEquipmentsAsync(pageNumber);
            }
            else
            {
                //Check page
                long equipmentCount = await FetchSearchEquipmentCountAsync(textBoxSearch.Text.Trim());
                totalPageNumber = (equipmentCount - 1) / 10 + 1;
                labelTotalPageNumber.Text = totalPageNumber.ToString();

                // Xoá toàn bộ cột và dữ liệu hiện tại trong DataGridView
                dataGridViewEquipment.Columns.Clear();
                dataGridViewEquipment.DataSource = null;

                equipments = await FetchSearchEquipmentsAsync(textBoxSearch.Text.Trim(), pageNumber);
            }

            if (equipments != null)
            {
                // Đặt dữ liệu vào DataGridView
                dataGridViewEquipment.DataSource = equipments;

                // Tạo cột "Hành động" với nút "Xoá"

                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "Delete";
                deleteColumn.HeaderText = "Xoá";
                deleteColumn.Text = "Xoá";
                deleteColumn.UseColumnTextForButtonValue = true;
                dataGridViewEquipment.Columns.Add(deleteColumn);

                // Đổi tên các cột trong DataGridView
                dataGridViewEquipment.Columns["EquipmentId"].HeaderText = "ID";
                dataGridViewEquipment.Columns["EquipmentName"].HeaderText = "Tên thiết bị";
                dataGridViewEquipment.Columns["TotalQuantity"].HeaderText = "Tổng số";
                dataGridViewEquipment.Columns["RemainQuantity"].HeaderText = "Còn lại";

                // Ẩn các cột không cần thiết
                dataGridViewEquipment.Columns["ImageUrl"].Visible = false;

                dataGridViewEquipment.Columns["EquipmentId"].ReadOnly = true;
                dataGridViewEquipment.Columns["EquipmentName"].ReadOnly = true;
                dataGridViewEquipment.Columns["TotalQuantity"].ReadOnly = true;
                dataGridViewEquipment.Columns["RemainQuantity"].ReadOnly = true;
                dataGridViewEquipment.Columns["ImageUrl"].ReadOnly = true;

                // Không cho phép thay đổi kích thước cột
                dataGridViewEquipment.AllowUserToResizeColumns = false;

                // Không cho phép thay đổi kích thước hàng
                dataGridViewEquipment.AllowUserToResizeRows = false;

                labelPageNumber.Text = pageNumber.ToString();
                labelTotalPageNumber.Text = totalPageNumber.ToString();
                // Reset value của text box
                textBoxEquipmentName.Text = "";
                textBoxTotalQuantity.Text = "";
                textBoxRemainQuantity.Text = "";
                pictureBoxEquipment.Image = null;
                buttonAddEquipmentToRoom.Visible = false;
            }
            else
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ API.");
            }
        }

        private async Task<Equipment> GetEquipmentFromApiAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Gửi yêu cầu GET đến API
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Kiểm tra nếu phản hồi thành công
                    response.EnsureSuccessStatusCode();

                    // Đọc nội dung JSON từ API
                    string json = await response.Content.ReadAsStringAsync();

                    // Chuyển đổi JSON thành đối tượng Equipment
                    Equipment equipment = JsonConvert.DeserializeObject<Equipment>(json);
                    return equipment;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi gọi API: {ex.Message}");
                    return null;
                }
            }
        }

        private async void DataGridViewEquipments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị của cột "Username" trong dòng được chọn
                Equipment selectedEquipment = ((List<Equipment>) dataGridViewEquipment.DataSource)[e.RowIndex];
                string imageUrl = "http://localhost:8080/" + selectedEquipment.ImageUrl;
                Equipment equipmentWithRooms = await GetEquipmentFromApiAsync("http://localhost:8080/admin/equipments/" + selectedEquipment.EquipmentId);
                string rooms = "";
                if (equipmentWithRooms.EquipmentId > 0)
                    buttonAddEquipmentToRoom.Visible = true;
                else
                    buttonAddEquipmentToRoom.Visible = false;
                if (equipmentWithRooms.Rooms != null && equipmentWithRooms.Rooms.Count > 0)
                {
                    // Sử dụng LINQ để lấy tên các phòng và nối thành một chuỗi
                    rooms = string.Join(", ", equipmentWithRooms.Rooms.Select(room => room.RoomName));
                }
                textBoxEquipmentName.Text = equipmentWithRooms.EquipmentName;
                textBoxTotalQuantity.Text = selectedEquipment.TotalQuantity.ToString();
                textBoxRemainQuantity.Text = selectedEquipment.RemainQuantity.ToString();
                labelRooms2.Text = rooms;
                this.currentEquipmentId = equipmentWithRooms.EquipmentId;
                LoadImageFromUrl(imageUrl);
            }
        }

        // Phương thức xoá
        private void DataGridViewEquipments_CellClickDeleteEquipment(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewEquipment.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridViewEquipment.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    string equipmentId = dataGridViewEquipment.Rows[e.RowIndex].Cells["EquipmentId"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xoá thiết bị với ID: {equipmentId}?", "Xoá người dùng", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        deleteEquipment(long.Parse(equipmentId));
                }
            }
        }

        private void iconButtonAddEquipment_Click(object sender, EventArgs e)
        {
            AddEquipment addEquipmentForm = new AddEquipment(this);
            addEquipmentForm.ShowDialog();
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

        private void buttonAddEquipmentToRoom_Click(object sender, EventArgs e)
        {
            AddEquipmentToRoom addEquipmentToRoomForm = new AddEquipmentToRoom(this, currentEquipmentId);
            addEquipmentToRoomForm.ShowDialog();
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
