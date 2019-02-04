using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;

namespace Assignment_Arena_Fighter
{
    class Battle
    {
        public static InfoGenerator InfoGen = new InfoGenerator(DateTime.Now.Millisecond);

        public Character Player { get; set; }
        public Battle Ai { get; set; }

        public List<int> Score { get; set; }
        public List<string> Battles { get; set; }

        public string AiName { get; set; }
        public int AiStrength { get; set; }
        public int AiDamage { get; set; }
        public int AiHealth { get; set; }

        public Battle(string AiName, int AiStrength, int AiDamage, int AiHealth)
        {
            this.AiName = AiName;
            this.AiStrength = AiStrength;
            this.AiDamage = AiDamage;
            this.AiHealth = AiHealth;

        }

        public void IsXAlive(Character player, Battle Ai)
        {
            this.Battles = Battles = new List<string>();
            this.Score = Score = new List<int>();

            int points = 0;

            if (player.playerHealth <= 0)
            {
                points = points + 2;
                Score.Add(points);

                string Lost = (player.PlayerName + " Slapped " + Ai.AiName + " with a tuna and lost!");
                Battles.Add(Lost);

                Round.FinalStatistics(player, Ai, Battles, Score);
            }
            else if (Ai.AiHealth <= 0)
            {
                points = points + 5;
                Score.Add(points);

                string Lost = (player.PlayerName + " Slapped " + Ai.AiName + " with a trout and won!");
                Battles.Add(Lost);

                Console.ReadKey();
                Program.TestingGrounds(player);
            }
            else
            {
                Round.BattleSequence(player, Ai);
            }
        }

        public void DisplayAi()
        {
            Program.DisplayMessage(
                "Opponent: \n" +
                "Name: " + AiName + "\n" +
                "Strength: " + AiStrength + "\n" +
                "Damage: " + AiDamage + "\n" +
                "Health: " + AiHealth + "\n");
        }
    }
}

