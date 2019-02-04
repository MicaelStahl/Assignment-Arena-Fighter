using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;

namespace Assignment_Arena_Fighter
{
    class Round
    {
        static InfoGenerator InfoGen = new InfoGenerator(DateTime.Now.Millisecond);

        public Character Player { get; set; }
        public Battle Ai { get; set; }
        public List<string> Battles { get; set; }
        public List<int> Score { get; set; }

        public static void FinalStatistics(Character player, Battle Ai, List<string> Battles, List<int> Score)
        {

            Console.Clear();
            Console.ReadKey();
            
            foreach (string value in Battles)
            {
                string line = value;
                Program.DisplayMessage(line + ".");

            }
            Console.ReadKey();

        }

        public Round(Character player, Battle Ai)
        {
            Console.Clear();


            this.Player = player;
            this.Ai = Ai;
            player.DisplayPlayer();
            Ai.DisplayAi();

            BattleSequence(player, Ai);
        }
        /// <summary>
        /// Performs the main Battle sequence and sends it over to the Battle class to verify that both chars are alive.
        /// </summary>
        public static void BattleSequence(Character player, Battle Ai)
        {

            Console.ReadKey();

            int playerDiceRoll = InfoGen.Next(1, 7);
            int AiDiceRoll = InfoGen.Next(1, 7);

            int playerStrength = player.playerStrength + playerDiceRoll;
            int AiStrength = Ai.AiStrength + AiDiceRoll;

            Program.DisplayMessage("---------------");
            Program.DisplayMessage("Rolls: "
                + player.PlayerName + " " + playerStrength + " (" + player.playerStrength + "+" + playerDiceRoll + ")" +
                " vs "
                + Ai.AiName + " " + AiStrength + " (" + Ai.AiStrength + "+" + AiDiceRoll + ")");

            if (playerStrength > AiStrength)
            {

                Program.DisplayMessage("I punched the opponent for " + player.playerDamage + "!", ConsoleColor.Green);

                Ai.AiHealth -= player.playerDamage;

                Program.DisplayMessage("Remaining Health: " + player.PlayerName + " (" + player.playerHealth + "), " + Ai.AiName + " (" + Ai.AiHealth + ")");

                Ai.IsXAlive(player, Ai);

                Console.ReadKey();
            }
            else if (playerStrength < AiStrength)
            {
                Program.DisplayMessage("Opponent punched me for " + Ai.AiDamage + "!", ConsoleColor.Red);

                player.playerHealth -= Ai.AiDamage; // can be read as playerhealth = playerhealth - AiDamage

                Program.DisplayMessage("Remaining Health: " + player.PlayerName + " (" + player.playerHealth + "), " + Ai.AiName + " (" + Ai.AiHealth + ")");

                Ai.IsXAlive(player, Ai);

            }
            else
            {
                Console.WriteLine("The predators circles around eachother, looking for a opening.");

                Program.DisplayMessage("Remaining Health: " + player.PlayerName + " (" + player.playerHealth + "), " + Ai.AiName + " (" + Ai.AiHealth + ")");

                Ai.IsXAlive(player, Ai);

            }
        }
    }
}
