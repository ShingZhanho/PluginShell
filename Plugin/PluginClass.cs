using System;

namespace Plugin {
    public abstract class PluginClass {
        public abstract void Run(string args);

        public abstract void InternalRun(string args);

        public abstract void ShowHelp();
    }
}