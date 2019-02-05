using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Arena_Fighter
{
    class Character
    {

        public Character() { }

        public string PlayerName { get; set; }
        public int playerStrength;
        public int playerDamage;
        public int playerHealth;
        public List<int> ShopMoney { get; set; }
        public List<string> Battles { get; set; }
        public List<int> Score { get; set; }

        public Character(string playerName, int playerStrength, int playerDamage, int playerHealth)
        {
            this.PlayerName = playerName;
            this.playerStrength = playerStrength;
            this.playerDamage = playerDamage;
            this.playerHealth = playerHealth;
            Battles = new List<string>();
            Score = new List<int>();
            ShopMoney = new List<int>();
        }

        public void DisplayPlayer()
        {
            Program.DisplayMessage(
                "\nPlayer: \n" +
                "Name: " + PlayerName + "\n" +
                "Strength: " + playerStrength + "\n" +
                "Damage: " + playerDamage + "\n" +
                "Health: " + playerHealth + "\n");
        }
    }
}
