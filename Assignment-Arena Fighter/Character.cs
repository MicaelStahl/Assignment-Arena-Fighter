using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;



namespace Assignment_Arena_Fighter
{
    class Character
    {

        public Character() { }

        public string playerName { get; set; }
        public int playerStrength { get; set; }
        public int playerDamage { get; set; }
        public int playerHealth { get; set; }

        public Character(string playerName, int playerStrength, int playerDamage, int playerHealth)
        {
            this.playerName = playerName;
            this.playerStrength = playerStrength;
            this.playerDamage = playerDamage;
            this.playerHealth = playerHealth;



        }

        public void DisplayPlayer()
        {
            Program.DisplayMessage(
                "Player: \n" +
                "Name: " + playerName + "\n" +
                "Strength: " + playerStrength + "\n" +
                "Damage: " + playerDamage + "\n" +
                "Health: " + playerHealth + "\n");

        }
    }
}
