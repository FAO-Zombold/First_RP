using System;
using GTANetworkAPI;

namespace First_RP.PlayerData
{
    class Data : Script
    {
        public static readonly String DataIdentifier = "PlayerInfo";
        public Client PlayerData { get; set; }
        public String Name { get; set; }
        public int Cash { get; set; }
        public int Age { get; set; }
        public int Health { get; set; }

        public Data(Client player)
        {
            PlayerData = player;
            Name = player.Name;
            Cash = 0;
            Age = 0;
            Health = 0;
        }

        public void SetHealth(int health)
        {
            Health = health + 10;
            PlayerData.Health = health;
        }
    }
}
