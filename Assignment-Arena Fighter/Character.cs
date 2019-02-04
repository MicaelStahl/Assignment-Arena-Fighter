using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;



namespace Assignment_Arena_Fighter
{
    class Character
    {

        public Character() { }

        public string PlayerName { get; set; }
        public int playerStrength;
        public int playerDamage;
        public int playerHealth;
        public List<string> Battles { get; set; }

        public Character(string playerName, int playerStrength, int playerDamage, int playerHealth)
        {
            this.PlayerName = playerName;
            this.playerStrength = playerStrength;
            this.playerDamage = playerDamage;
            this.playerHealth = playerHealth;
            Battles = new List<string>();
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
