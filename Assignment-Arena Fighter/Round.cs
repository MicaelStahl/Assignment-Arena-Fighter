using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;

namespace Assignment_Arena_Fighter
{
    class Round
    {
        static InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);

        public Round() { }

        //public Battle DiceRoll(int diceRoll)
        //{
        //    this.diceRoll = diceRoll;
        //    diceRoll = infoGen.Next(1, 7);

        //    return new Battle(diceRoll);

        //}

        //public Character(string AiName, int AiStrength, int AiDamage, int AiHealth)
        //{

        //    AiStrength = infoGen.Next(1, 9);
        //    AiDamage = infoGen.Next(1, 7);
        //    AiHealth = infoGen.Next(1, 9);
        //    Console.WriteLine("AiName = " + AiName);
        //    Console.WriteLine("AiStrength = " + AiStrength);
        //    Console.WriteLine("AiDamage = " + AiDamage);
        //    Console.WriteLine("AiHealth = " + AiHealth);

        //    return new Character(AiStrength, AiDamage, AiHealth);

        //}
    }
}
