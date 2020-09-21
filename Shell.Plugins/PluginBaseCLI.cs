using Shell.Settings;

namespace Shell.Plugins {
    public abstract class PluginBaseCLI {

        public abstract void Run();

        public virtual void ShowError(string errorMsg, bool exit = false, int exitCode = 1) {
            
        }
    }
}