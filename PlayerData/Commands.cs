using System;
using GTANetworkAPI;

namespace First_RP.PlayerData
{
    class Commands : Script
    {
        [Command("test", Alias = "t")]
        public void CMD_Test(Client player)
        {
            player.SendChatMessage("Test Command");
        }
    }
}
