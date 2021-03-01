using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EmailGenerator
{
    public class Generator
    {
        public Generator()
        {
            _settings = ImportSettings();
        }

        public string GenerateNew()
        {
            string[] parts = Email.Split('@');
            if (parts.Length != 2)
                return parts[0];

            Index = Index + 1;
            return $"{parts[0]}{Separator}{Index}@{parts[1]}";
        }

        public void SaveSettings()
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                if (fs.CanWrite)
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        string text = JsonSerializer.Serialize(_settings);
                        sw.Write(text);
                    }
                }
            }
        }

        public string Email
        {
            get => _settings.Email;
            set => _settings.Email = value;
        }

        public string Separator
        {
            get => _settings.Separator;
            set => _settings.Separator = value;
        }

        public int Index
        {
            get => _settings.Index;
            set => _settings.Index = value;
        }

        private SettingsModel ImportSettings()
        {
            SettingsModel model = new SettingsModel();
            try
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.Open))
                {
                    if (fs.CanRead)
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string text = sr.ReadToEnd();
                            model = JsonSerializer.Deserialize<SettingsModel>(text);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                return model;
            }

            return model;
        }

        private readonly SettingsModel _settings;
        private const string FilePath = "appsettings.json";
    }
}
