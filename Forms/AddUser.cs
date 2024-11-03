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
    public partial class AddUser : Form
    {
        private UserManagement _userManagementForm;

        public AddUser(UserManagement userManagementForm)
        {
            InitializeComponent();
            _userManagementForm = userManagementForm;
            comboBoxGender.SelectedIndex = 0;
            comboBoxRole.SelectedIndex = 0;
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control
            string fullName = textBoxFullName.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            bool gender = comboBoxGender.SelectedItem.ToString() == "Nam";
            string role = comboBoxGender.SelectedItem.ToString();
            string dob = dateTimePickerDob.Value.ToString("yyyy-MM-dd");

            // Tạo object chứa thông tin người dùng
            var userData = new
            {
                fullName = fullName,
                gender = gender,
                phoneNumber = phoneNumber,
                dob = dob,
                username = username,
                password = password
            };

            // Chuyển object thành JSON
            string json = JsonConvert.SerializeObject(userData);

            // Gửi POST request tới API
            using (var client = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:8080/admin/users", content);
                Console.WriteLine(response.StatusCode);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Người dùng đã được tạo thành công!");
                    long userCount = await _userManagementForm.FetchUsersCountAsync();
                    long totalPageNumber = (userCount - 1) / 10 + 1;
                    _userManagementForm.LoadDataIntoGridView(1);
                    _userManagementForm.labelPageNumber.Text = totalPageNumber.ToString();
                    _userManagementForm.labelTotalPageNumber.Text = totalPageNumber.ToString();
                    this.Close();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Có lỗi xảy ra khi tạo người dùng: {error}");
                }
            }
        }
    }
}
