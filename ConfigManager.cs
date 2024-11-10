using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentManagementWinform
{
    public class AppSettings
    {
        public string BaseUrl { get; set; }
    }

    public static class ConfigManager
    {
        private static readonly string configFilePath = "appsettings.json";
        private static AppSettings _settings;

        // Thuộc tính tĩnh để truy cập URL gốc từ bất kỳ đâu
        public static string BaseUrl { get; private set; }

        public static AppSettings LoadSettings()
        {
            if (_settings == null)
            {
                var json = File.ReadAllText(configFilePath);
                _settings = JsonConvert.DeserializeObject<AppSettings>(json);
                BaseUrl = _settings.BaseUrl; // Lưu URL vào thuộc tính tĩnh
            }
            return _settings;
        }
    }
}
