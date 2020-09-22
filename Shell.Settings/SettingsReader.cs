using System;
using System.IO;
using IniParser;
using IniParser.Model;
using IniParser.Parser;

namespace Shell.Settings {
    public class SettingsReader {
        public SettingsReader() {
            // Create settings from default settings if not exist
            if (!File.Exists("./Config/shellConfig.ini"))
                File.Copy("./Config/default_shellConfig.ini", "./Config/shellConfig.ini");

            _settingFile = Path.GetFullPath("./Config/shellConfig.ini");
            
            _loadSettingsFromFile();
        }

        private static string _settingFile;

        private static IniData _iniData;
        
        private void _loadSettingsFromFile() {
            _iniData = new FileIniDataParser().ReadFile(_settingFile);
        }

        public bool? GetBoolSettings(string path) {
            var value = GetStringSettings(path);

            switch (value) {
                // path: use format section.key
                case null:
                    // TODO: call CLI to write error line
                    return null;
                case "allowOnce":
                case "true":
                    return true;
                case "false":
                    return false;
                default:
                    // TODO: call CLI to write: Not a bool entry
                    return null;
            }
        }

        public string GetStringSettings(string path) {
            return _iniData[path.Split('.')[0]][path.Split('.')[1]];
        }
    }
}