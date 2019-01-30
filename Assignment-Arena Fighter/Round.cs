using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Arena_Fighter
{
    class Round
    {
        private int diceRoll;

        public Round() { }

        public Battle DiceRoll(int diceRoll)
        {
            this.diceRoll = diceRoll;
            Random random = new Random();
            int dice = random.Next(1, 7);

            return new Battle(diceRoll);

        }

        public Round(int AiStrength, int AiDamage, int AiHealth)
        {
            Random random = new Random();
            AiStrength = random.Next(1, 9);
            AiDamage = random.Next(1, 7);
            AiHealth = random.Next(1, 9);
            Console.WriteLine("AiStrength = " + AiStrength);
            Console.WriteLine("AiDamage = " + AiDamage);
            Console.WriteLine("AiHealth = " + AiHealth);

            //return new Character(AiStrength, AiDamage, AiHealth);

        }

        public Round(int diceRoll)
        {
            this.diceRoll = diceRoll;
        }
    }
}
