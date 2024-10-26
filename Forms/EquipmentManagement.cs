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
            public int TotalQuantity { get; set; }
            public int RemainQuantity { get; set; }
            public List<Room> Rooms { get; set; }
        }

        public EquipmentManagement()
        {
            InitializeComponent();
            //string imageUrl = "http://localhost:8080/uploads/equipments/abbb.jpg";
            //LoadImageFromUrl(imageUrl);
            LoadDataIntoGridView();
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

        private async Task<List<Equipment>> FetchEquipmentsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = "http://localhost:8080/admin/equipments/all-quantities?page=0";
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

        public async void LoadDataIntoGridView()
        {
            // Huỷ đăng ký sự kiện cũ (nếu có)
            dataGridViewEquipment.CellClick -= DataGridViewUsers_CellClick;
            List<Equipment> equipments = await FetchEquipmentsAsync();
            if (equipments != null)
            {
                // Đặt dữ liệu vào DataGridView
                dataGridViewEquipment.DataSource = equipments;

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

                // Xử lý sự kiện nhấn nút "Sửa" và "Xoá"
                dataGridViewEquipment.CellContentClick += (s, e) =>
                {
                    if (e.ColumnIndex == dataGridViewEquipment.Columns["Delete"].Index && e.RowIndex >= 0)
                    {
                        // Xoá user logic
                        string userId = dataGridViewEquipment.Rows[e.RowIndex].Cells["EquipmentId"].Value.ToString();
                        DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xoá thiết bị với ID: {userId}?", "Xoá người dùng", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // Thực hiện gọi API hoặc logic xoá user
                            MessageBox.Show($"Xoá thông tin thiết bị với ID: {userId}");
                        }
                    }
                };
                // Sự kiện khi nhấn vào một dòng trong DataGridView
                dataGridViewEquipment.CellClick += DataGridViewUsers_CellClick;
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

        private async void DataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị của cột "Username" trong dòng được chọn
                Equipment selectedEquipment = ((List<Equipment>) dataGridViewEquipment.DataSource)[e.RowIndex];
                string imageUrl = "http://localhost:8080/" + selectedEquipment.ImageUrl;
                Equipment equipmentWithRooms = await GetEquipmentFromApiAsync("http://localhost:8080/admin/equipments/" + selectedEquipment.EquipmentId);
                string rooms = "";
                if (equipmentWithRooms.Rooms != null && equipmentWithRooms.Rooms.Count > 0)
                {
                    // Sử dụng LINQ để lấy tên các phòng và nối thành một chuỗi
                    rooms = string.Join(", ", equipmentWithRooms.Rooms.Select(room => room.RoomName));
                }
                textBoxEquipmentName.Text = equipmentWithRooms.EquipmentName;
                textBoxTotalQuantity.Text = equipmentWithRooms.TotalQuantity.ToString();
                textBoxRemainQuantity.Text = equipmentWithRooms.RemainQuantity.ToString();
                labelRooms2.Text = rooms;
                LoadImageFromUrl(imageUrl);
            }
        }

        private void iconButtonAddEquipment_Click(object sender, EventArgs e)
        {
            AddEquipment addEquipmentForm = new AddEquipment();
            addEquipmentForm.ShowDialog();
        }
    }
}
