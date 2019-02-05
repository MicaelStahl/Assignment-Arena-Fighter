using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;

namespace Assignment_Arena_Fighter
{
    class Battle
    {
        public static InfoGenerator InfoGen = new InfoGenerator(DateTime.Now.Millisecond);

        //public Character Player { get; set; }
        //public Battle Ai { get; set; }

        int points = 0;
        int shopMoney = 0;

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


            if (player.playerHealth <= 0)
            {
                points = points + 2;
                player.Score.Add(points);

                string Lost = (player.PlayerName + " Slapped " + Ai.AiName + " with a tuna and lost");
                player.Battles.Add(Lost);

                Console.ReadKey();
                Round.FinalStatistics(player, Ai);
            }
            else if (Ai.AiHealth <= 0)
            {
                shopMoney = shopMoney + InfoGen.Next(2, 5);
                player.ShopMoney.Add(shopMoney);

                points = points + 5;
                player.Score.Add(points);

                string Lost = (player.PlayerName + " Slapped " + Ai.AiName + " with a trout and won");
                player.Battles.Add(Lost);

                Console.ReadKey();
                Program.Testing(player);
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

