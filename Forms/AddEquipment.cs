using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentManagementWinform.Forms
{
    public partial class AddEquipment : Form
    {
        private EquipmentManagement _equipmentManagementForm;
        private string selectedImagePath = "";

        public AddEquipment(EquipmentManagement equipmentManagementForm)
        {
            InitializeComponent();
            _equipmentManagementForm = equipmentManagementForm;
        }

        private async Task<bool> CreateEquipmentAsync(string url, string equipmentName, string imagePath)
        {
            using (HttpClient client = new HttpClient())
            using (MultipartFormDataContent form = new MultipartFormDataContent())
            {
                try
                {
                    // Thêm equipmentName vào form-data
                    form.Add(new StringContent(equipmentName), "equipmentName");

                    // Thêm image vào form-data (file ảnh)
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        byte[] imageBytes = File.ReadAllBytes(imagePath);
                        ByteArrayContent imageContent = new ByteArrayContent(imageBytes);
                        imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                        form.Add(imageContent, "image", Path.GetFileName(imagePath));
                    }
                    // Gửi yêu cầu POST đến API
                    HttpResponseMessage response = await client.PostAsync(url, form);

                    // Kiểm tra nếu yêu cầu thành công
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Tạo thiết bị thành công!");
                        return true;
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Lỗi khi tạo thiết bị: {error}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                    return false;
                }
            }
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    MessageBox.Show($"Đã chọn ảnh: {Path.GetFileName(selectedImagePath)}");
                    pictureBoxEquipmentImage.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private async void buttonAdd_ClickAsync(object sender, EventArgs e)
        {
            string apiUrl = "http://localhost:8080/admin/equipments";
            string equipmentName = textBoxEquipmentName.Text;

            if (string.IsNullOrEmpty(equipmentName))
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị");
                return;
            }

            bool isSuccess = await CreateEquipmentAsync(apiUrl, equipmentName, selectedImagePath);
            if (isSuccess)
            {
                // Xử lý sau khi tạo thành công (nếu cần)
                long userCount = await _equipmentManagementForm.FetchEquipmentCountAsync();
                long totalPageNumber = (userCount - 1) / 10 + 1;
                // Trang mới nhất
                _equipmentManagementForm.LoadDataIntoGridView(totalPageNumber);
                _equipmentManagementForm.labelPageNumber.Text = totalPageNumber.ToString();
                _equipmentManagementForm.labelTotalPageNumber.Text = totalPageNumber.ToString();
                this.Close();
            }
        }
    }
}
