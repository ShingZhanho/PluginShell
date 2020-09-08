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
                case "indicator":
                    ShowInputIndicator();
                    break;
                case "exit":
                    Exit(arguments);
                    break;
            }
        }

        public override void InternalRun(string args) {
            
        }

        public override void ShowHelp() {
            Console.WriteLine("This is base plugin's help message.");
        }

        private static void Exit(string exitCode = null) {
            if (exitCode != null) Environment.Exit(TryParse(exitCode, out _) ? Parse(exitCode) : 1);
            Environment.Exit(-1);
        }

        private static void ShowInputIndicator() {
            Console.Write("$ ");
        }
    }
}