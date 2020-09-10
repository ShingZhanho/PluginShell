using System;
using Shell.InternalPlugins;

namespace Shell {
    class Program {
        static void Main(string[] args) {
            // Initializes internal plugins
            var basePlugin = new BasePlugin();
            var pluginManager = new PluginManager();
            
            // TODO: Load plugins
            
            while (true) {
                basePlugin.InternalRun("indicator");
                var command = Console.ReadLine();
                if (command == string.Empty) continue;

                var arguments = string.Empty;
                for (var i = 1; i < command.Split(' ').Length; i++)
                    arguments += $@"{command.Split(' ')[i]} ";

                // Look for internal plugins first
                switch (command.Split(' ')[0]) {
                    case "shell":
                        basePlugin.Run(arguments);
                        break;
                    case "pm":
                        pluginManager.Run(arguments);
                        break;
                }
            }
        }
    }
}