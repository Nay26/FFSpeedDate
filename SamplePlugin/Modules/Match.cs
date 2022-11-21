using FFSpeedDate.Windows;
using ImGuiNET;

namespace FFSpeedDate.Modules
{
    public class Match
    {
        private readonly MainWindow MainWindow;
        public bool Enabled = false;

        private Configuration Config;

        public Match(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            Config = MainWindow.Config;
            Initialize();
        }

        public void Dispose()
        { 
        }

        public void Initialize()
        {
           
        }

        public void DrawMatch()
        {
            ImGui.Text("Match");
        }
    }
    
}
