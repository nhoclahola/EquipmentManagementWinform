using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EquipmentManagementWinform.Forms
{
    public partial class AddRoom : Form
    {
        public class Room
        {
            public string roomName;

            public Room(string roomName)
            {
                this.roomName = roomName;
            }
        }

        private RoomManagement roomManagementForm;

        public AddRoom(RoomManagement roomManagementForm)
        {
            InitializeComponent();
            this.roomManagementForm = roomManagementForm;
        }

        private async void buttonAddRoom_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                Room room = new Room(textBoxRoomName.Text);
                // Chuyển object thành JSON
                string json = JsonConvert.SerializeObject(room);
                Console.WriteLine(json);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"http://localhost:8080/admin/rooms", content);
                Console.WriteLine(response.StatusCode);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Đã thêm phòng {room.roomName}");
                    long roomCount = await roomManagementForm.FetchRoomCountAsync();
                    long totalPageNumber = (roomCount - 1) / 10 + 1;
                    roomManagementForm.LoadDataIntoGridViewRooms(totalPageNumber);
                    this.Close();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Có lỗi xảy ra khi thêm phòng {room.roomName}: {error}");
                }
            }
        }
    }
}
