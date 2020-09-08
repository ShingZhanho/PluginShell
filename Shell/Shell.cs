using System;
using Shell.InternalPlugins;

namespace Shell {
    class Program {
        static void Main(string[] args) {
            // Initializes internal plugins
            var basePlugin = new BasePlugin();
            
            // TODO: Load plugins
            
            while (true) {
                basePlugin.InternalRun("indicator");
                var command = Console.ReadLine();
                if (command == string.Empty) continue;

                var arguments = string.Empty;
                for (var i = 1; i < command.Split(' ').Length; i++)
                    arguments += $"{command.Split(' ')[i]} ";

                switch (command.Split(' ')[0]) {
                    case "shell":
                        basePlugin.Run(arguments);
                        break;
                }
            }
        }
    }
}