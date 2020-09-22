using System;
using Shell.Utils;
using Shell.Settings;

namespace Shell.Plugins {
    public abstract class PluginBaseCLI {

        public abstract void Run();

        public virtual void ShowError(string errorMsg, bool exit = false, int exitCode = 1, string blockLabel = " ERROR ") {
            var shAppearance = new ShellAppearance();
            
            // Display a block with text "ERROR"
            Console.ForegroundColor = shAppearance.ErrorBlockForeColor;
            Console.BackgroundColor = shAppearance.ErrorBlockBackColor;
            Console.Write(blockLabel);
            
            // Display error message
            Console.BackgroundColor = shAppearance.BackColor;
            Console.ForegroundColor = shAppearance.ErrorMsgForeColor;
            Console.Write($" {errorMsg}\n");
            
            // Set foreground color back to normal
            Console.ForegroundColor = shAppearance.ForeColor;
            
            if (exit) Environment.Exit(exitCode);
        }
    }
}