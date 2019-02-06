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

        public static void FinalStatistics(Character player, Battle Ai)
        {
            int pointyPoints = 0;
            Console.Clear();

            Program.DisplayMessage("Final statistics:");
            player.DisplayPlayer();

            foreach (string value in player.Battles)
            {
                string line = value;
                Program.DisplayMessage(line + "!");

            }
            foreach (int points in player.Score)
            {
                pointyPoints = pointyPoints + points;
            }

            Program.DisplayMessage("Your total score: " + pointyPoints);
            Console.ReadKey();
        }

        public Round(Character player, Battle Ai)
        {
            Console.Clear();


            //this.Player = player;
            //this.Ai = Ai;
            player.DisplayPlayer();
            Ai.DisplayAi();

            Console.ReadKey();

            BattleSequence(player, Ai);
        }

        /// <summary>
        /// Performs the main Battle sequence and sends it over to the Battle class to verify that both chars are alive.
        /// </summary>
        public static void BattleSequence(Character player, Battle Ai)
        {

            int playerDiceRoll = InfoGen.Next(1, 7);
            int AiDiceRoll = InfoGen.Next(1, 7);

            int playerStrength = player.Strength + playerDiceRoll;
            int AiStrength = Ai.Strength + AiDiceRoll;

            Program.DisplayMessage("---------------");
            Program.DisplayMessage(
                "Rolls: "
                + player.Name + " " + playerStrength + " (" + player.Strength + "+" + playerDiceRoll + ")" +
                " vs "
                + Ai.Name + " " + AiStrength + " (" + Ai.Strength + "+" + AiDiceRoll + ")"
                );

            if (playerStrength > AiStrength)
            {

                Program.DisplayMessage("I punched the opponent for " + player.Damage + "!", ConsoleColor.Green);

                Ai.Health -= player.Damage;

                Program.DisplayMessage("Remaining Health: " + player.Name + " (" + ((player.Health <= 0) ? "Dead" : player.Health.ToString()) + "), " + Ai.Name + " (" + ((Ai.Health <= 0) ? "Dead" : Ai.Health.ToString()) + ")");

            }
            else if (playerStrength < AiStrength)
            {
                Program.DisplayMessage("Opponent punched me for " + Ai.Damage + "!", ConsoleColor.Red);

                player.Health -= Ai.Damage; // can be read as playerhealth = playerhealth - AiDamage

                                Program.DisplayMessage("Remaining Health: " + player.Name + " (" + ((player.Health <= 0) ? "Dead" : player.Health.ToString()) + "), " + Ai.Name + " (" + ((Ai.Health <= 0) ? "Dead" : Ai.Health.ToString()) + ")");

            }
            else
            {
                Console.WriteLine("The predators circles around eachother, looking for a opening.");

                Program.DisplayMessage("Remaining Health: " + player.Name + " (" + player.Health + "), " + Ai.Name + " (" + Ai.Health + ")");

            }
            Console.ReadKey();
            Ai.IsXAlive(player, Ai);
        }
    }
}
