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
        Round UserChar = new Round();
        
        public Character(int CharStrength, int CharDamage, int CharHealth)
        {
            this.CharStrength = CharStrength;
            this.CharDamage = CharDamage;
            this.CharHealth = CharHealth;
        }
        public Character(string CharName,int CharStrength, int CharDamage, int CharHealth)
        {
            this.CharName = CharName;
            this.CharStrength = CharStrength;
            this.CharDamage = CharDamage;
            this.CharHealth = CharHealth;

            Console.WriteLine(
                "Name: " + CharName + "\n" +
                "Strength: " + CharStrength + "\n" +
                "Damage: " + CharDamage + "\n" +
                "Health: " + CharHealth);
        }

    }
}
