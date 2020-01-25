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
            this.PlayerData = player;
            this.Name = player.Name;
            this.Cash = 0;
            this.Age = 0;
            this.Health = 0;
        }

        public void SetHealth(int health)
        {
            this.Health = health;
            this.PlayerData.Health = health;
            return;
        }
    }
}
