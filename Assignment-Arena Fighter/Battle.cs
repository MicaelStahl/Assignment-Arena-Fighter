using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;

namespace Assignment_Arena_Fighter
{
    class Battle
    {
        public static InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);
        private Battle opponent;
        private Character player;

        public Battle(Character player)
        {
            Character opponent = CreateOpponent();
            opponent.DisplayOpponent();

        }
        public static Character CreateOpponent()
        {
            return new Character(infoGen.Next(1, 9), infoGen.Next(1, 6), infoGen.Next(2, 9));//Sends strength, damage and health to a constructor in Character class
        }
        public Battle(Character player, Character opponent)
        {
            BattleSequence(player, opponent);
        }

        public Battle(Character player, Battle opponent)
        {
            this.player = player;
            this.opponent = opponent;
        }

        public void BattleSequence(Character player, Character opponent)
        {
            if (player.playerHealth > opponent.AiHealth)
            {
                Console.WriteLine("I punched the opponent!");
                Console.ReadKey();
            }
            else if(player.playerHealth < opponent.AiHealth)
            {
                Console.WriteLine("Opponent punched me!");
                Console.ReadKey();
            }
        }

        static void DiceRoll()
        {
            int DiceRoll = infoGen.Next(1, 7);
            Console.WriteLine("Dice roll: " + DiceRoll);

        }
    }
}
