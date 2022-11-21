using FFSpeedDate.Windows;
using ImGuiNET;

namespace FFSpeedDate.Modules
{
    public class PlayerList
    {
        private readonly MainWindow mainWindow;
        public bool Enabled = false;

        private Configuration Config;

        public PlayerList(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            Config = MainWindow.Config;
            Initialize();
        }

        public void Dispose()
        { 
        }

        public void Initialize()
        {
           
        }

        public void DrawPlayerList()
        {
            ImGui.Text("Player List");
        }
    }
    
}
