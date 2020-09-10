using System;

namespace Shell.InternalPlugins {
    public partial class PluginManager : Plugin.PluginClass {
        public override void Run(string arg) {
            var arguments = string.Empty;
            for (var i = 1; i < arg.Split(' ').Length - 1; i++) {
                arguments += arg.Split(' ')[i] + " ";
            }

            switch (arg.Split(' ')[0]) {
                case "help":
                    ShowHelp();
                    break;
                case "install":
                    InstallPackage(arguments);
                    break;
                default:
                    ShowError("Command not found.", false);
                    break;
            }
        }

        public override void InternalRun(string arg) {
            
        }

        public override void ShowHelp() {
            
        }

        public override void ShowError(string message, bool exit) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            if (exit) Environment.Exit(1);
        }
    }
}