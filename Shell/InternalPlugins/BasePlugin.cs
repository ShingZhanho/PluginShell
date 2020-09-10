using System;
using System.Globalization;
using Plugin;
using static System.Int32;

namespace Shell.InternalPlugins {
    public class BasePlugin : PluginClass {
        public override void Run(string arg) {
            var arguments = string.Empty;
            for (var i = 1; i < arg.Split(' ').Length - 1; i++) {
                arguments += arg.Split(' ')[i] + " ";
            }

            switch (arg.Split(' ')[0]) {
                case "help":
                    ShowHelp();
                    break;
                case "exit":
                    Exit(arguments);
                    break;
                default:
                    ShowError("Command not found.", false);
                    break;
            }
        }

        public override void InternalRun(string arg) {
            var arguments = string.Empty;
            for (var i = 1; i < arg.Split(' ').Length - 1; i++) {
                arguments += $"{arg.Split(' ')[i]} ";
            }

            switch (arg.Split(' ')[0]) {
                case "indicator":
                    ShowInputIndicator();
                    break;
            }
        }

        public override void ShowHelp() {
            Console.WriteLine("This is core plugin's help message.");
        }

        public override void ShowError(string msg, bool exit) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
            if (exit) Exit("1");
        }
        
        private static void Exit(string exitCode = null) {
            if (exitCode != null) Environment.Exit(TryParse(exitCode, out _) ? Parse(exitCode) : 1);
            Environment.Exit(-1);
        }

        private static void ShowInputIndicator() {
            Console.Write("\n$ ");
        }

    }
}