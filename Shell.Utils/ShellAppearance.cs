using System;
using Shell.Settings;

namespace Shell.Utils {
    /// <summary>
    /// This class stores all setting values inside shAppearance section
    /// </summary>
    public class ShellAppearance {
        public ShellAppearance() {
            ForeColor = _getConsoleColor("shAppearance.foreColor");
            BackColor = _getConsoleColor("shAppearance.backColor");
            ErrorBlockForeColor = _getConsoleColor("shAppearance.errorBlockForeColor");
            ErrorBlockBackColor = _getConsoleColor("shAppearance.errorBlockBackColor");
            ErrorMsgForeColor = _getConsoleColor("shAppearance.errorMsgForeColor");
            WarningBlockForeColor = _getConsoleColor("shAppearance.warningBlockForeColor");
            WarningBlockBackColor = _getConsoleColor("shAppearance.warningBlockBackColor");
            WarningMsgForeColor = _getConsoleColor("shAppearance.warningMsgForeColor");
        }
        
        public ConsoleColor ForeColor { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ErrorBlockForeColor { get; set; }
        public ConsoleColor ErrorBlockBackColor { get; set; }
        public ConsoleColor ErrorMsgForeColor { get; set; }
        public ConsoleColor WarningBlockForeColor { get; set; }
        public ConsoleColor WarningBlockBackColor { get; set; }
        public ConsoleColor WarningMsgForeColor { get; set; }

        private ConsoleColor _getConsoleColor(string path) {
            var reader = new SettingsReader();
            return ConsoleColor.TryParse(
                reader.GetStringSettings(path),
                true,
                out ConsoleColor color)
                ? color
                : ConsoleColor.Black; // If value cannot be parsed, black is returned.
        }
    }
}