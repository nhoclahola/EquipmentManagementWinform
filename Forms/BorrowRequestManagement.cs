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

namespace EquipmentManagementWinform.Forms
{
    public partial class BorrowRequestManagement : Form
    {
        public class User
        {
            public long UserId { get; set; }
            public string FullName { get; set; }
            public bool? Gender { get; set; }
            public string PhoneNumber { get; set; }
            public string Role { get; set; }
            public string Username { get; set; }
        }

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

        public class BorrowRequest
        {
            public long Id { get; set; }
            public User User { get; set; }
            public Equipment Equipment { get; set; }
            public Room Room { get; set; }
            public string RequestDate { get; set; }
            public string BorrowDate { get; set; }
            public string ReturnDate { get; set; }

            public long UserId => User.UserId;
            public string Username => User.Username;

            public long RoomId => Room.RoomId;
            public string RoomName => Room?.RoomName;
            public long EquipmentId => Equipment.EquipmentId;
            public string EquipmentName => Equipment?.EquipmentName;

            public long Quantity { get; set; }
            public string Status { get; set; }
            public bool Returned { get; set; }
        }

        private long currentPageNumber = 1;
        private BorrowRequest currentBorrowRequest;

        public BorrowRequestManagement()
        {
            InitializeComponent();

            dataGridViewBorrowRequest.ColumnHeadersHeight = 50; // Tăng chiều cao của header

            // Tùy chỉnh DataGridView
            dataGridViewBorrowRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBorrowRequest.DefaultCellStyle.BackColor = Color.White;
            dataGridViewBorrowRequest.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewBorrowRequest.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridViewBorrowRequest.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Tùy chỉnh tiêu đề cột
            dataGridViewBorrowRequest.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewBorrowRequest.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewBorrowRequest.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewBorrowRequest.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Căn chỉnh dữ liệu
            dataGridViewBorrowRequest.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Tùy chỉnh đường viền ô
            dataGridViewBorrowRequest.GridColor = Color.Black;
            dataGridViewBorrowRequest.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewBorrowRequest.RowHeadersVisible = false;  // Ẩn tiêu đề hàng

            // Cài đặt tự động điều chỉnh kích thước cột
            dataGridViewBorrowRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridViewBorrowRequest.CellClick += DataGridViewBorrowRequest_CellClick;
            dataGridViewBorrowRequest.CellFormatting += dataGridViewBorrowRequest_CellFormatting;
            dataGridViewBorrowRequest.CellFormatting += dataGridViewBorrowRequest_CellFormattingDate;
            LoadDataIntoGridView(currentPageNumber);    // Khởi đầu là 1
        }

        public async Task<long> FetchBorrowRequestCountAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = "http://localhost:8080/admin/borrow-request/count";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string countString = await response.Content.ReadAsStringAsync();
                    return long.Parse(countString);
                }
                return 0;
            }
        }

        private async Task<List<BorrowRequest>> FetchBorrowRequestsAsync(long pageNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                // Thay endpoint API của bạn ở đây
                string apiUrl = $"http://localhost:8080/admin/borrow-request?page={pageNumber}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // Deserialize JSON thành danh sách User
                    List<BorrowRequest> borrowRequests = JsonConvert.DeserializeObject<List<BorrowRequest>>(jsonResponse);
                    return borrowRequests;
                }
                return null;
            }
        }

        public async void LoadDataIntoGridView(long pageNumber)
        {
            //Check page
            long equipmentCount = await FetchBorrowRequestCountAsync();
            long totalPageNumber = (equipmentCount - 1) / 10 + 1;
            labelTotalPageNumber.Text = totalPageNumber.ToString();

            // Xoá toàn bộ cột và dữ liệu hiện tại trong DataGridView
            dataGridViewBorrowRequest.Columns.Clear();
            dataGridViewBorrowRequest.DataSource = null;

            List<BorrowRequest> borrowRequests = await FetchBorrowRequestsAsync(pageNumber);
            if (borrowRequests != null)
            {
                // Đặt dữ liệu vào DataGridView
                dataGridViewBorrowRequest.DataSource = borrowRequests;

                // Tạo cột "Hành động" với nút "Xoá"
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "Delete";
                deleteColumn.HeaderText = "Xoá";
                deleteColumn.Text = "Xoá";
                deleteColumn.UseColumnTextForButtonValue = true;
                dataGridViewBorrowRequest.Columns.Add(deleteColumn);

                // Đổi tên các cột trong DataGridView
                dataGridViewBorrowRequest.Columns["Id"].HeaderText = "ID";
                dataGridViewBorrowRequest.Columns["UserId"].HeaderText = "ID người dùng";
                dataGridViewBorrowRequest.Columns["Username"].HeaderText = "Username";
                dataGridViewBorrowRequest.Columns["RoomId"].HeaderText = "ID phòng";
                dataGridViewBorrowRequest.Columns["RoomName"].HeaderText = "Tên phòng";
                dataGridViewBorrowRequest.Columns["EquipmentId"].HeaderText = "ID thiết bị";
                dataGridViewBorrowRequest.Columns["EquipmentName"].HeaderText = "Tên thiết bị";
                dataGridViewBorrowRequest.Columns["Quantity"].HeaderText = "Số lượng mượn";
                dataGridViewBorrowRequest.Columns["RequestDate"].HeaderText = "Ngày yêu cầu";
                dataGridViewBorrowRequest.Columns["BorrowDate"].HeaderText = "Ngày mượn";
                dataGridViewBorrowRequest.Columns["ReturnDate"].HeaderText = "Ngày trả";
                dataGridViewBorrowRequest.Columns["Status"].HeaderText = "Tình trạng";
                dataGridViewBorrowRequest.Columns["Returned"].HeaderText = "Đã trả";


                //dataGridViewBorrowRequest.Columns["RemainQuantity"].HeaderText = "Còn lại";

                // Ẩn các cột không cần thiết
                dataGridViewBorrowRequest.Columns["User"].Visible = false;
                dataGridViewBorrowRequest.Columns["Room"].Visible = false;
                dataGridViewBorrowRequest.Columns["RoomId"].Visible = false;
                dataGridViewBorrowRequest.Columns["Equipment"].Visible = false;
                dataGridViewBorrowRequest.Columns["EquipmentId"].Visible = false;
                //dataGridViewBorrowRequest.Columns["RequestDate"].Visible = false;
                dataGridViewBorrowRequest.Columns["BorrowDate"].Visible = false;
                dataGridViewBorrowRequest.Columns["ReturnDate"].Visible = false;

                dataGridViewBorrowRequest.Columns["Returned"].Width = 45;

                //dataGridViewBorrowRequest.Columns["EquipmentId"].ReadOnly = true;
                //dataGridViewBorrowRequest.Columns["EquipmentName"].ReadOnly = true;
                //dataGridViewBorrowRequest.Columns["TotalQuantity"].ReadOnly = true;
                //dataGridViewBorrowRequest.Columns["RemainQuantity"].ReadOnly = true;
                //dataGridViewBorrowRequest.Columns["ImageUrl"].ReadOnly = true;

                // Không cho phép thay đổi kích thước cột
                dataGridViewBorrowRequest.AllowUserToResizeColumns = false;

                // Không cho phép thay đổi kích thước hàng
                dataGridViewBorrowRequest.AllowUserToResizeRows = false;

                labelPageNumber.Text = pageNumber.ToString();
                labelTotalPageNumber.Text = totalPageNumber.ToString();
                // Reset value của text box
                textBoxRequestDate.Text = "";
                textBoxBorrowDate.Text = "";
                textBoxReturnDate.Text = "";
                textBoxRoomId.Text = "";
                textBoxEquipmentId.Text = "";
                labelStatus.Text = "";
                buttonApprove.Visible = false;
                buttonReject.Visible = false;
                buttonReturned.Visible = false;
                this.currentBorrowRequest = null;
            }
            else
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ API.");
            }
        }

        private void dataGridViewBorrowRequest_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu cột đang được định dạng là cột "Status"
            if (dataGridViewBorrowRequest.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                // Lấy giá trị của ô
                string status = e.Value.ToString();

                // Thay đổi giá trị hiển thị dựa trên trạng thái
                switch (status)
                {
                    case "PENDING":
                        e.Value = "Đang xử lý";
                        break;
                    case "APPROVED":
                        e.Value = "Chấp nhận";
                        break;
                    case "REJECTED":
                        e.Value = "Từ chối";
                        break;
                }

                // Đánh dấu là đã định dạng để ngăn `DataGridView` định dạng lại
                e.FormattingApplied = true;
            }
        }

        private void dataGridViewBorrowRequest_CellFormattingDate(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu cột đang được định dạng là cột "RequestDate"
            if (dataGridViewBorrowRequest.Columns[e.ColumnIndex].Name == "RequestDate" && e.Value != null)
            {
                // Kiểm tra nếu giá trị của ô là null hoặc rỗng
                if (e.Value == DBNull.Value || e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
                {
                    e.Value = ""; // Hiển thị chuỗi rỗng nếu giá trị là null
                }
                else
                {
                    // Chuyển đổi giá trị thành DateTime và định dạng lại
                    DateTime dateValue;
                    if (DateTime.TryParse(e.Value.ToString(), out dateValue))
                    {
                        e.Value = dateValue.ToString("dd/MM/yyyy");
                        e.FormattingApplied = true; // Đánh dấu là đã áp dụng định dạng
                    }
                }
            }
        }

        private async void DataGridViewBorrowRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BorrowRequest selectedBorrowRequest = ((List<BorrowRequest>) dataGridViewBorrowRequest.DataSource)[e.RowIndex];
                Console.WriteLine(selectedBorrowRequest.Returned);
                if (selectedBorrowRequest.Status.Equals("PENDING"))
                {
                    labelStatus.Text = "Yêu cầu này chưa được xử lý!";
                    buttonApprove.Visible = true;
                    buttonReject.Visible = true;
                    buttonReturned.Visible = false;
                }
                else if (selectedBorrowRequest.Status.Equals("APPROVED") && selectedBorrowRequest.Returned == false)
                {
                    labelStatus.Text = "Yêu cầu này đã được chấp nhận nhưng chưa được trả!";
                    buttonApprove.Visible = false;
                    buttonReject.Visible = false;
                    buttonReturned.Visible = true;
                }
                else if (selectedBorrowRequest.Status.Equals("APPROVED") && selectedBorrowRequest.Returned == true)
                {
                    labelStatus.Text = "Yêu cầu này đã được chấp nhận và đã được trả!";
                    buttonApprove.Visible = false;
                    buttonReject.Visible = false;
                    buttonReturned.Visible = false;
                }
                else if (selectedBorrowRequest.Status.Equals("REJECTED"))
                {
                    labelStatus.Text = "Yêu cầu này đã bị từ chối!";
                    buttonApprove.Visible = false;
                    buttonReject.Visible = false;
                    buttonReturned.Visible = false;
                }    

                // Date
                if (selectedBorrowRequest.RequestDate != null)
                    textBoxRequestDate.Text = DateTime.ParseExact(selectedBorrowRequest.RequestDate, "yyyy-MM-dd", null).ToString("dd/MM/yyyy");
                else
                    textBoxRequestDate.Text = "";
                if (selectedBorrowRequest.BorrowDate != null)
                    textBoxBorrowDate.Text = DateTime.ParseExact(selectedBorrowRequest.BorrowDate, "yyyy-MM-dd", null).ToString("dd/MM/yyyy");
                else
                    textBoxBorrowDate.Text = "";
                if (selectedBorrowRequest.ReturnDate != null)
                    textBoxReturnDate.Text = DateTime.ParseExact(selectedBorrowRequest.ReturnDate, "yyyy-MM-dd", null).ToString("dd/MM/yyyy");
                else
                    textBoxBorrowDate.Text = "";

                //
                textBoxRoomId.Text = selectedBorrowRequest.RoomId.ToString();
                textBoxEquipmentId.Text = selectedBorrowRequest.EquipmentId.ToString();
                this.currentBorrowRequest = selectedBorrowRequest;
            }
        }

        private async void iconButtonNextPage_Click(object sender, EventArgs e)
        {
            //Check page
            long borrowRequestCount = await FetchBorrowRequestCountAsync();
            long totalPageNumber = (borrowRequestCount - 1) / 10 + 1;
            currentPageNumber = long.Parse(labelPageNumber.Text);
            if (currentPageNumber < totalPageNumber)
            {
                currentPageNumber += 1;
                LoadDataIntoGridView(currentPageNumber);
            }
        }

        private async void iconButtonPreviousPage_Click(object sender, EventArgs e)
        {
            //Check page
            long borrowRequestCount = await FetchBorrowRequestCountAsync();
            long totalPageNumber = (borrowRequestCount - 1) / 10 + 1;
            currentPageNumber = long.Parse(labelPageNumber.Text);
            if (currentPageNumber > 1)
            {
                currentPageNumber -= 1;
                LoadDataIntoGridView(currentPageNumber);
            }
        }

        private async void buttonReject_Click(object sender, EventArgs e)
        {
            if (currentBorrowRequest != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Từ chối yêu cầu mượn thiết bị này?", "Từ chối cho mượn thiết bị", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var client = new HttpClient())
                    {
                        var content = new StringContent("", Encoding.UTF8, "application/json");
                        var response = await client.PutAsync($"http://localhost:8080/admin/borrow-request/{currentBorrowRequest.Id}/reject", content);
                        Console.WriteLine(response.StatusCode);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Đã từ chối cho mượn thiết bị {currentBorrowRequest.EquipmentName} tại phòng {currentBorrowRequest.RoomName} !");
                            LoadDataIntoGridView(currentPageNumber);
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Có lỗi xảy ra khi thực hiện yêu cầu: {error}");
                        }
                    }
                }
            }
        }

        private async void buttonApprove_Click(object sender, EventArgs e)
        {
            if (currentBorrowRequest != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Chấp nhận yêu cầu mượn thiết bị này?", "Chấp nhận cho mượn thiết bị", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var client = new HttpClient())
                    {
                        var content = new StringContent("", Encoding.UTF8, "application/json");
                        var response = await client.PutAsync($"http://localhost:8080/admin/borrow-request/{currentBorrowRequest.Id}/approve", content);
                        Console.WriteLine(response.StatusCode);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Đã chấp nhận cho mượn thiết bị {currentBorrowRequest.EquipmentName} tại phòng {currentBorrowRequest.RoomName} !");
                            LoadDataIntoGridView(currentPageNumber);
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Có lỗi xảy ra khi thực hiện yêu cầu: {error}");
                        }
                    }
                }
            }
        }

        private async void buttonReturned_Click(object sender, EventArgs e)
        {
            if (currentBorrowRequest != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Đánh dấu thiết bị này đã được trả?", "Trả thiết bị", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var client = new HttpClient())
                    {
                        var content = new StringContent("", Encoding.UTF8, "application/json");
                        var response = await client.PutAsync($"http://localhost:8080/admin/borrow-request/{currentBorrowRequest.Id}/returned", content);
                        Console.WriteLine(response.StatusCode);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Đã đánh dấu thiết bị {currentBorrowRequest.EquipmentName} được trả lại phòng {currentBorrowRequest.RoomName} !");
                            LoadDataIntoGridView(currentPageNumber);
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Có lỗi xảy ra khi thực hiện yêu cầu: {error}");
                        }
                    }
                }
            }
        }
    }
}
