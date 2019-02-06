using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Arena_Fighter
{
    class Character
    {

        public Character() { }

        public string Name { get; set; }
        public int Strength;
        public int Damage;
        public int Health;
        public List<int> ShopMoney { get; set; }
        public List<string> Battles { get; set; }
        public List<int> Score { get; set; }

        public Character(string Name, int Strength, int Damage, int Health)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Damage = Damage;
            this.Health = Health;
            Battles = new List<string>();
            Score = new List<int>();
            ShopMoney = new List<int>();
        }

        public void DisplayPlayer()
        {

            Program.DisplayMessage(
                "\nPlayer: \n" +
                "Name: " + Name + "\n" +
                "Strength: " + Strength + "\n" +
                "Damage: " + Damage + "\n" +
                "Health: " + ((Health <= 0) ? "Dead" : Health.ToString()) + "\n");
        }
    }
}
