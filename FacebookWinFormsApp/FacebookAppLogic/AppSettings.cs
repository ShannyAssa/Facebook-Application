using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using System.Xml.Serialization;
using System.IO;

namespace BasicFacebookFeatures.FacebookAppLogic
{
    public sealed class AppSettings
    {
        private const string k_AppSettingsPath = @".\AppSettings.xml";

        public bool RememberUser { get; set; }
        
        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = new AppSettings();

            if (File.Exists(k_AppSettingsPath))
            {
                using (Stream stream = new FileStream(k_AppSettingsPath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return appSettings;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(k_AppSettingsPath, File.Exists(k_AppSettingsPath) 
                ? FileMode.Truncate : FileMode.CreateNew))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
