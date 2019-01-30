using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Arena_Fighter
{
    class Battle
    {
        public int DiceRoll;

        public Battle(int DiceRoll)
        {
            this.DiceRoll = DiceRoll;
            Console.WriteLine("Dice roll: " + DiceRoll);
        }
    }
}
