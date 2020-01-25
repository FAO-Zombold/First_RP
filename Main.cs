using System;
using GTANetworkAPI;

namespace First_RP
{
    public class Main : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            NAPI.Util.ConsoleOutput("System gestartet");
            NAPI.Server.SetGlobalServerChat(false);
        }

        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnected(Client player)
        {
            NAPI.Util.ConsoleOutput(player.Name + " ist beigetreten.");
            PlayerData.Data Player = new PlayerData.Data(player);
            player.SetData(PlayerData.Data.DataIdentifier, Player);
        }

        [ServerEvent(Event.PlayerSpawn)]
        public void OnPlayerSpawn(Client player)
        {
            if (player.HasData(PlayerData.Data.DataIdentifier))
            {
                var Player = player.GetData(PlayerData.Data.DataIdentifier);
                Player.setHealth = 50;
            }
        }

        [ServerEvent(Event.ChatMessage)]
        public void OnChatMessage(Client player, string msg)
        {
            var nearestPlayers = NAPI.Player.GetPlayersInRadiusOfPlayer(5, player);
            foreach(Client Item in nearestPlayers)
            {
                Logging(player.Name + ": " + msg, 2);
                Item.SendChatMessage(player.Name + ": " + msg);
            }
        }

        public void Logging(string msg, int mode)
        {
            if(mode == 0)
            {
                NAPI.Util.ConsoleOutput("[FAO] [LOG] " + msg);
            }
            else if(mode == 1)
            {
                NAPI.Util.ConsoleOutput("[FAO] [ERR] " + msg);
            }
            else if (mode == 2)
            {
                NAPI.Util.ConsoleOutput("[FAO] [CHAT] " + msg);
            }
        }
    }
}
