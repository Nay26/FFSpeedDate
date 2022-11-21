using Dalamud.Interface;
using FFSpeedDate.Models;
using FFSpeedDate.Windows;
using ImGuiNET;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace FFSpeedDate.Modules
{
    public class PlayerList
    {
        private readonly MainWindow mainWindow;
        public bool Enabled = false;
        public List<Player> players;
        public Player newPlayer;
        private int gender;

        private Configuration Config;

        public PlayerList(MainWindow mainWindow)
        {
            newPlayer = new Player();
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
            ImGui.Text("Add Player:");
            DrawAddPlayer();

            ImGui.Text("Player List:");
            DrawPlayers();
        }

        private void DrawAddPlayer()
        {
            ImGui.Columns(6);
            ImGui.SetColumnWidth(0, 90 + 5 * ImGuiHelpers.GlobalScale); //First name
            ImGui.SetColumnWidth(1, 90 + 5 * ImGuiHelpers.GlobalScale); //Second Name
            ImGui.SetColumnWidth(2, 140 + 5 * ImGuiHelpers.GlobalScale); //Gender
            ImGui.SetColumnWidth(3, 90 + 5 * ImGuiHelpers.GlobalScale); //Likes M?
            ImGui.SetColumnWidth(4, 90 + 5 * ImGuiHelpers.GlobalScale); //Likes F?
            ImGui.SetColumnWidth(5, 50 + 5 * ImGuiHelpers.GlobalScale); //Add

            ImGui.Separator();

            ImGui.Text("First name");
            ImGui.NextColumn();
            ImGui.Text("Second name");
            ImGui.NextColumn();
            ImGui.Text("Gender");
            ImGui.NextColumn();
            ImGui.Text("Likes M?");
            ImGui.NextColumn();
            ImGui.Text("Likes F?");
            ImGui.NextColumn();
            ImGui.Text("Add");
            ImGui.NextColumn();

            ImGui.Separator();

            ImGui.InputText($"###firstName", ref newPlayer.FirstName, 255);
            ImGui.NextColumn();
            ImGui.InputText($"###secondName", ref newPlayer.SecondName, 255);
            ImGui.NextColumn();
            ImGui.Combo($"###gender", ref gender, new string[] {Gender.Male.ToString(), Gender.Female.ToString()},2);
            ImGui.NextColumn();
            ImGui.Checkbox($"###likesMale", ref newPlayer.LikesMale);
            ImGui.NextColumn();
            ImGui.Checkbox($"###likesFemale", ref newPlayer.LikesFemale);
            ImGui.NextColumn();
            ImGui.Button($"###addPlayer", new Vector2(40,25));
            ImGui.NextColumn();

            ImGui.Separator();
            ImGui.Columns(1);
        }

        private void DrawPlayers()
        {
            ImGui.Columns(6);
            ImGui.SetColumnWidth(0, 90 + 5 * ImGuiHelpers.GlobalScale); //First name
            ImGui.SetColumnWidth(1, 90 + 5 * ImGuiHelpers.GlobalScale); //Second Name
            ImGui.SetColumnWidth(2, 140 + 5 * ImGuiHelpers.GlobalScale); //Gender
            ImGui.SetColumnWidth(3, 90 + 5 * ImGuiHelpers.GlobalScale); //Likes M?
            ImGui.SetColumnWidth(4, 90 + 5 * ImGuiHelpers.GlobalScale); //Likes F?
            ImGui.SetColumnWidth(5, 50 + 5 * ImGuiHelpers.GlobalScale); //Remove

            ImGui.Separator();

            ImGui.Text("First name");
            ImGui.NextColumn();
            ImGui.Text("Second name");
            ImGui.NextColumn();
            ImGui.Text("Gender");
            ImGui.NextColumn();
            ImGui.Text("Likes M?");
            ImGui.NextColumn();
            ImGui.Text("Likes F?");
            ImGui.NextColumn();
            ImGui.Text("Remove");
            ImGui.NextColumn();

            ImGui.Separator();

            foreach (var player in players)
            {
                ImGui.Text(player.FirstName);
                ImGui.NextColumn();
                ImGui.Text(player.SecondName);
                ImGui.NextColumn();
                ImGui.Text(player.Gender.ToString());
                ImGui.NextColumn();
                ImGui.Text(player.LikesMale ? "Yes" : "No");
                ImGui.NextColumn();
                ImGui.Text(player.LikesFemale ? "Yes" : "No");
                ImGui.NextColumn();
                ImGui.Button($"###removePlayer", new Vector2(40, 25));
                ImGui.NextColumn();
                ImGui.Separator();
            }

           
            ImGui.Columns(1);
        }
    }
    
}
