using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EquipmentManagementWinform.Forms.AddEquipmentToRoom;
using static EquipmentManagementWinform.Forms.EquipmentManagement;

namespace EquipmentManagementWinform.Forms
{
    public partial class AddEquipmentToRoom : Form
    {
        public class Room
        {
            public long RoomId { get; set; }
            public string RoomName { get; set; }
        }

        public class Equipment
        {
            public long EquipmentId { get; set; }
            public string EquipmentName { get; set; }
            public string ImageUrl { get; set; }
        }

        public class RoomEquipments
        {
            public Room Room { get; set; }
            public Equipment Equipment { get; set; }
            // Thuộc tính bổ sung để hiển thị RoomName và EquipmentName
            public string RoomName => Room?.RoomName;
            public string EquipmentName => Equipment?.EquipmentName;
            public long EquipmentId => Equipment.EquipmentId;
            public long Quantity { get; set; }
            public long RemainQuantity { get; set; }
        }

        private EquipmentManagement equipmentManagementForm;
        private long equipmentId;

        private long currentPageNumber = 1;
        private long roomId;        // To add
        private string roomName;

        public AddEquipmentToRoom(EquipmentManagement equipmentManagementForm, long equipmentId)
        {
            InitializeComponent();
            this.equipmentManagementForm = equipmentManagementForm;
            this.equipmentId = equipmentId;
            dataGridViewRooms.CellClick += DataGridViewRoomEquipment_CellClick;
            LoadDataIntoGridViewRooms(currentPageNumber);    // Khởi đầu là 1
        }

        public async Task<long> FetchRoomCountAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = "http://localhost:8080/admin/rooms/count";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    return long.Parse(countString);
                }

                return 0;
            }
        }

        private async Task<List<Room>> FetchRoomsAsync(long pageNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = $"http://localhost:8080/admin/rooms?page={pageNumber}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // Deserialize JSON thành danh sách User
                    List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(jsonResponse);
                    return rooms;
                }
                return null;
            }
        }

        private async Task<List<RoomEquipments>> FetchRoomsEquipmentAsync(long roomId)
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = $"http://localhost:8080/admin/rooms/{roomId}/equipments";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<RoomEquipments> roomEquipments = JsonConvert.DeserializeObject<List<RoomEquipments>>(jsonResponse);
                    return roomEquipments;
                }
                Console.WriteLine(response.StatusCode);
                return null;
            }
        }

        private async Task<RoomEquipments> FetchGetRoomEquipment(long roomId, long equipmentId)
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = $"http://localhost:8080/admin/rooms/{roomId}/equipments/{equipmentId}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    RoomEquipments roomEquipment = JsonConvert.DeserializeObject<RoomEquipments>(jsonResponse);
                    return roomEquipment;
                }
                Console.WriteLine(response.StatusCode);
                return null;
            }
        }

        private async Task<bool> CheckEquipmentExistsInRoom(long roomId, long equipmentId)
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = $"http://localhost:8080/admin/rooms/{roomId}/equipments/{equipmentId}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // Deserialize JSON thành danh sách User
                    bool isExist = JsonConvert.DeserializeObject<bool>(jsonResponse);
                    return isExist;
                }
                return false;
            }
        }

        public async void LoadDataIntoGridViewRooms(long pageNumber)
        {
            //Check page
            long equipmentCount = await FetchRoomCountAsync();
            long totalPageNumber = (equipmentCount - 1) / 10 + 1;
            labelTotalPageNumber.Text = totalPageNumber.ToString();

            // Xoá toàn bộ cột và dữ liệu hiện tại trong DataGridView
            dataGridViewRooms.Columns.Clear();
            dataGridViewRooms.DataSource = null;

            List<Room> equipments = await FetchRoomsAsync(pageNumber);
            if (equipments != null)
            {
                // Đặt dữ liệu vào DataGridView
                dataGridViewRooms.DataSource = equipments;

                // Tùy chỉnh DataGridView
                dataGridViewRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewRooms.DefaultCellStyle.BackColor = Color.White;
                dataGridViewRooms.DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewRooms.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
                dataGridViewRooms.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                // Tùy chỉnh tiêu đề cột
                dataGridViewRooms.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                dataGridViewRooms.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dataGridViewRooms.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Căn chỉnh dữ liệu
                dataGridViewRooms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                // Tùy chỉnh đường viền ô
                dataGridViewRooms.GridColor = Color.Black;
                dataGridViewRooms.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dataGridViewRooms.RowHeadersVisible = false;  // Ẩn tiêu đề hàng

                // Cài đặt tự động điều chỉnh kích thước cột
                dataGridViewRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                // Đổi tên các cột trong DataGridView
                dataGridViewRooms.Columns["RoomId"].HeaderText = "ID";
                dataGridViewRooms.Columns["RoomName"].HeaderText = "Tên phòng";

                // Readonly
                dataGridViewRooms.Columns["RoomId"].ReadOnly = true;
                dataGridViewRooms.Columns["RoomName"].ReadOnly = true;

                // Không cho phép thay đổi kích thước cột
                dataGridViewRooms.AllowUserToResizeColumns = false;

                // Không cho phép thay đổi kích thước hàng
                dataGridViewRooms.AllowUserToResizeRows = false;
            }
            else
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ API.");
            }
        }

        private async void DataGridViewRoomEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Room selectedRoom = ((List<Room>) dataGridViewRooms.DataSource)[e.RowIndex];
                //await FetchRoomsEquipmentAsync(selectedRoom.RoomId);
                //currentRoom = selectedRoom;
                LoadDataIntoGridViewRoomEquipments(selectedRoom.RoomId);
                this.roomId = selectedRoom.RoomId;
                this.roomName = selectedRoom.RoomName;
                RoomEquipments roomEquipment = await FetchGetRoomEquipment(selectedRoom.RoomId, this.equipmentId);
                if (roomEquipment != null)
                {
                    labelCheckEquipmentExistsInRoom.Text = $"Thiết bị này đã tồn tại tại phòng {roomEquipment.RoomName}";
                    textBoxRoomName.Text = roomEquipment.RoomName;
                    textBoxQuantity.Text = roomEquipment.Quantity.ToString();
                    textBoxRemainQuantity.Text = roomEquipment.RemainQuantity.ToString();
                    buttonUpdate.Visible = true;
                    buttonAdd.Visible = false;
                    buttonDelete.Visible = true;
                }
                else
                {
                    labelCheckEquipmentExistsInRoom.Text = $"Thiết bị này chưa tồn tại tại phòng {selectedRoom.RoomName}";
                    textBoxRoomName.Text = selectedRoom.RoomName;
                    textBoxQuantity.Text = "";
                    textBoxRemainQuantity.Text = "";
                    buttonAdd.Visible = true;
                    buttonUpdate.Visible = false;
                    buttonDelete.Visible = true;
                }
            }
        }

        public async void LoadDataIntoGridViewRoomEquipments(long roomId)
        {
            //Check page
            //long equipmentCount = await FetchRoomCountAsync();
            //long totalPageNumber = (equipmentCount - 1) / 10 + 1;
            //labelTotalPageNumber.Text = totalPageNumber.ToString();

            // Xoá toàn bộ cột và dữ liệu hiện tại trong DataGridView
            dataGridViewRoomEquipments.Columns.Clear();
            dataGridViewRoomEquipments.DataSource = null;

            List<RoomEquipments> roomEquipments = await FetchRoomsEquipmentAsync(roomId);
            if (roomEquipments != null)
            {
                // Đặt dữ liệu vào DataGridView
                dataGridViewRoomEquipments.DataSource = roomEquipments;

                // Tùy chỉnh DataGridView
                dataGridViewRoomEquipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewRoomEquipments.DefaultCellStyle.BackColor = Color.White;
                dataGridViewRoomEquipments.DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewRoomEquipments.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
                dataGridViewRoomEquipments.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                // Tùy chỉnh tiêu đề cột
                dataGridViewRoomEquipments.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                dataGridViewRoomEquipments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewRoomEquipments.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dataGridViewRoomEquipments.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Căn chỉnh dữ liệu
                dataGridViewRoomEquipments.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                // Tùy chỉnh đường viền ô
                dataGridViewRoomEquipments.GridColor = Color.Black;
                dataGridViewRoomEquipments.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dataGridViewRoomEquipments.RowHeadersVisible = false;  // Ẩn tiêu đề hàng

                // Cài đặt tự động điều chỉnh kích thước cột
                dataGridViewRoomEquipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                // Thêm các cột để hiển thị thông tin
                dataGridViewRoomEquipments.Columns["Room"].Visible = false;
                dataGridViewRoomEquipments.Columns["Equipment"].Visible = false;

                dataGridViewRoomEquipments.Columns["RoomName"].HeaderText = "Tên phòng";
                dataGridViewRoomEquipments.Columns["EquipmentName"].HeaderText = "Tên thiết bị";
                dataGridViewRoomEquipments.Columns["EquipmentId"].HeaderText = "ID thiết bị";
                dataGridViewRoomEquipments.Columns["Quantity"].HeaderText = "Số lượng";
                dataGridViewRoomEquipments.Columns["RemainQuantity"].HeaderText = "Còn lại";


                // Không cho phép thay đổi kích thước cột
                dataGridViewRoomEquipments.AllowUserToResizeColumns = false;

                // Không cho phép thay đổi kích thước hàng
                dataGridViewRoomEquipments.AllowUserToResizeRows = false;

            }
            else
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ API.");
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                long quantity = long.Parse(textBoxQuantity.Text);
                var content = new StringContent("", Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"http://localhost:8080/admin/rooms/{this.roomId}/add/{this.equipmentId}?quantity={quantity}", content);
                Console.WriteLine(response.StatusCode);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Đã thêm thiết bị vào phòng {this.roomName}!");
                    this.LoadDataIntoGridViewRoomEquipments(this.roomId);
                    buttonUpdate.Visible = true;
                    buttonAdd.Visible = false;
                    equipmentManagementForm.LoadDataIntoGridView(1);
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Có lỗi xảy ra khi thêm thiết bị vào phòng {this.roomId}: {error}");
                }
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                long quantity = long.Parse(textBoxQuantity.Text);
                var content = new StringContent("", Encoding.UTF8, "application/json");
                var response = await client.PutAsync($"http://localhost:8080/admin/rooms/{this.roomId}/edit/{this.equipmentId}?quantity={quantity}", content);
                Console.WriteLine(response.StatusCode);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Đã cập nhật số lượng thiết bị cho phòng {this.roomName}!");
                    this.LoadDataIntoGridViewRoomEquipments(this.roomId);
                    buttonUpdate.Visible = true;
                    buttonAdd.Visible = false;
                    equipmentManagementForm.LoadDataIntoGridView(1);
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Có lỗi xảy ra khi thêm thiết bị vào phòng {this.roomId}: {error}");
                }
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                long quantity = long.Parse(textBoxQuantity.Text);
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xoá thiết bị với ID: {equipmentId}? khỏi phòng {this.roomName}", "Xoá thiết bị khỏi phòng", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var response = await client.DeleteAsync($"http://localhost:8080/admin/rooms/{this.roomId}/delete/{this.equipmentId}?quantity={quantity}");
                    Console.WriteLine(response.StatusCode);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Đã xoá thiết bị với ID: {equipmentId}? khỏi phòng {this.roomName}");
                        this.LoadDataIntoGridViewRoomEquipments(this.roomId);
                        buttonUpdate.Visible = false;
                        buttonAdd.Visible = true;
                        buttonDelete.Visible = false;
                        equipmentManagementForm.LoadDataIntoGridView(1);
                        textBoxQuantity.Text = "";
                        textBoxRemainQuantity.Text = "";
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Có lỗi xảy ra khi xoá thiết bị khỏi phòng {this.roomName}: {error}");
                    }
                }    
            }
        }
    }
}
