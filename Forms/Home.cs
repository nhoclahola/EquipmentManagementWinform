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

namespace EquipmentManagementWinform.Forms
{
    public partial class Home : Form
    {
        public class Room
        {
            public long RoomId { get; set; }
            public string RoomName { get; set; }
            public bool Borrowed { get; set; }
        }

        public long currentPageNumber = 1;
        private long totalPageNumber;

        public Home()
        {
            InitializeComponent();

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
            LoadDataIntoGridViewRooms(currentPageNumber);    // Khởi đầu là 1

            FetchUsersCountAsync();
            FetchRoomCountAsync();
            FetchEquipmentCountAsync();
            FetchPendingRoomEquipmentsCountAsync();
            FetchPendingBorrowRequestCountAsync();
            FetchPendingRoomBorrowRequestCountAsync();
        }

        public async Task<long> FetchUsersCountAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{ConfigManager.BaseUrl}/admin/users/count";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    textBoxTotalUsers.Text = countString;
                    return long.Parse(countString);
                }

                return 0;
            }
        }

        public async Task<long> FetchEquipmentCountAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{ConfigManager.BaseUrl}/admin/equipments/count";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    textBoxTotalEquipments.Text = countString;
                    return long.Parse(countString);
                }

                return 0;
            }
        }

        public async Task<long> FetchPendingBorrowRequestCountAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{ConfigManager.BaseUrl}/admin/borrow-request/count-pending";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    textBoxPendingBorrowRequest.Text = countString;
                    return long.Parse(countString);
                }

                return 0;
            }
        }

        public async Task<long> FetchPendingRoomBorrowRequestCountAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{ConfigManager.BaseUrl}/admin/room-borrow-request/count-pending";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    textBoxPendingRoomBorrowRequest.Text = countString;
                    return long.Parse(countString);
                }

                return 0;
            }
        }

        public async Task<long> FetchPendingRoomEquipmentsCountAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{ConfigManager.BaseUrl}/admin/room-equipments/count";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    textBoxTotalRoomEquipments.Text = countString;
                    return long.Parse(countString);
                }

                return 0;
            }
        }

        public async Task<long> FetchRoomCountAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{ConfigManager.BaseUrl}/admin/rooms/count";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    textBoxTotalRooms.Text = countString;
                    return long.Parse(countString);
                }

                return 0;
            }
        }

        private async Task<List<Room>> FetchRoomsAsync(long pageNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{ConfigManager.BaseUrl}/admin/rooms?page={pageNumber}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(jsonResponse);
                    return rooms;
                }
                return null;
            }
        }

        public async void LoadDataIntoGridViewRooms(long pageNumber)
        {
            List<Room> rooms;
            //Check page
            long roomCount = await FetchRoomCountAsync();
            totalPageNumber = (roomCount - 1) / 10 + 1;
            labelTotalPageNumber.Text = totalPageNumber.ToString();
            // Xoá toàn bộ cột và dữ liệu hiện tại trong DataGridView
            dataGridViewRooms.Columns.Clear();
            dataGridViewRooms.DataSource = null;
            rooms = await FetchRoomsAsync(pageNumber);

            if (rooms != null)
            {
                // Đặt dữ liệu vào DataGridView
                dataGridViewRooms.DataSource = rooms;

                // Đổi tên các cột trong DataGridView
                dataGridViewRooms.Columns["RoomId"].HeaderText = "ID";
                dataGridViewRooms.Columns["RoomName"].HeaderText = "Tên phòng";
                dataGridViewRooms.Columns["Borrowed"].HeaderText = "Đang mượn";


                // Readonly
                dataGridViewRooms.Columns["RoomId"].ReadOnly = true;
                dataGridViewRooms.Columns["RoomName"].ReadOnly = true;

                // Không cho phép thay đổi kích thước cột
                dataGridViewRooms.AllowUserToResizeColumns = false;

                // Không cho phép thay đổi kích thước hàng
                dataGridViewRooms.AllowUserToResizeRows = false;

                labelPageNumber.Text = pageNumber.ToString();
                labelTotalPageNumber.Text = totalPageNumber.ToString();
            }
            else
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ API.");
            }
        }

        private async void iconButtonNextPage_Click(object sender, EventArgs e)
        {
            //Check page
            currentPageNumber = long.Parse(labelPageNumber.Text);
            if (currentPageNumber < totalPageNumber)
            {
                currentPageNumber += 1;
                labelPageNumber.Text = currentPageNumber.ToString();
                LoadDataIntoGridViewRooms(currentPageNumber);
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
                LoadDataIntoGridViewRooms(currentPageNumber);
            }
        }
    }
}
