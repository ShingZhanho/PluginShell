using System;

namespace Plugin {
    public abstract class PluginClass {
        public abstract void Run(string arg);

        public abstract void InternalRun(string arg);

        public abstract void ShowHelp();
    }
}