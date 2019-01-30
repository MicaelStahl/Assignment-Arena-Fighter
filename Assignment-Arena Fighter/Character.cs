using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;

namespace Assignment_Arena_Fighter
{
    class Character
    {
        public Character()
        {
        }
        public string CharName { get; set; }
        public int CharStrength;
        public int CharDamage;
        public int CharHealth;
        

        public string AiName { get; set; }
        public int AiStrength;
        public int AiDamage;
        public int AiHealth;

        public Character(int AiStrength, int AiDamage, int AiHealth)
        {
            this.AiStrength = AiStrength;
            this.AiDamage = AiDamage;
            this.AiHealth = AiHealth;
        }
        public Character(string CharName, int CharStrength, int CharDamage, int CharHealth)
        {
            this.CharName = CharName;
            this.CharStrength = CharStrength;
            this.CharDamage = CharDamage;
            this.CharHealth = CharHealth;

            //private Round(int AiStrength, int AiDamage, int AiHealth)
            //{
            //    this.AiStrength = AiStrength;
            //    this.AiDamage = AiDamage;
            //    this.AiHealth = AiHealth;
            //}

            Console.WriteLine(
                "Name: " + CharName + "\n" +
                "Strength: " + CharStrength + "\n" +
                "Damage: " + CharDamage + "\n" +
                "Health: " + CharHealth);

            
            //Console.WriteLine(
            //    "Name: " + AiName + "\n" +
            //    "Strength: " + AiStrength + "\n" +
            //    "Damage: " + AiDamage + "\n" +
            //    "Health: " + AiHealth);
        }

    }
}
