using System.IO;
using IniParser;

namespace Shell.Settings {
    public class SettingsReader {
        public SettingsReader(string settingsFile) {
            if (!File.Exists(settingsFile))
                throw new FileNotFoundException($"File '{settingsFile}' does not exist.");
        }
    }
}