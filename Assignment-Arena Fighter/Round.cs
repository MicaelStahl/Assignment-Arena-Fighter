﻿using System;
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



        public static void ScoreScreen(Character player, Battle Ai)
        {

            List<Battle> ScoreScreen = new List<Battle>();
            ScoreScreen.Add(Ai);

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

        public static void BattleSequence(Character player, Battle Ai)
        {
            bool stayAlive = true;
            int points = 0;

            List<int> Score = new List<int>();

            while (stayAlive)
            {
                int playerDiceRoll = InfoGen.Next(1, 7);
                int opponentDiceRoll = InfoGen.Next(1, 7);

                int playerStrength = player.playerStrength + playerDiceRoll;
                int AiStrength = Ai.AiStrength + opponentDiceRoll;

                Program.DisplayMessage("---------------");
                Program.DisplayMessage("Rolls: "
                    + player.playerName + " " + playerStrength + " (" + player.playerStrength + "+" + playerDiceRoll + ")" +
                    " vs "
                    + Ai.AiName + " " + AiStrength + " (" + Ai.AiStrength + "+" + opponentDiceRoll + ")");

                if (playerStrength > AiStrength)
                {
                    Program.DisplayMessage("I punched the opponent for " + player.playerDamage + "!", ConsoleColor.Green);

                    Ai.AiHealth -= player.playerDamage;
                    Program.DisplayMessage(Ai.AiHealth + " health remaining ");

                    if (Ai.AiHealth <= 0)
                    {
                        points = points + 5;
                        Score.Add(points);

                        Program.DisplayMessage("Opponent has 0 health remaining, which results in a win for you!");

                        Program.DisplayMessage(points + " is your current score!");

                        Round.ScoreScreen(player, Ai); // ------------------------------------------
                    }
                    Console.ReadKey();
                }
                else if (playerStrength < AiStrength)
                {
                    Program.DisplayMessage("Opponent punched me for " + Ai.AiDamage + "!", ConsoleColor.Red);

                    player.playerHealth -= Ai.AiDamage;
                    Program.DisplayMessage(player.playerHealth + " health remaining ");

                    if (player.playerHealth <= 0)
                    {
                        points = points + 2;
                        Score.Add(points);
                        Program.DisplayMessage("You have 0 health remaining, which means you suck!");
                        Program.DisplayMessage(points + " is your final score!");
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("The predators circles around eachother, looking for a opening.");
                    Console.ReadKey();
                }
            }
        }
    }
}
