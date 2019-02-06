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

        //public Character Player { get; set; }
        //public Battle Ai { get; set; }

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }

        public Battle(string Name, int Strength, int Damage, int Health)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Damage = Damage;
            this.Health = Health;

        }

        public void IsXAlive(Character player, Battle Ai)
        {
            //bool stayAlive = true;

            //while (stayAlive)
            //{
                //player.DisplayPlayer();
                //Ai.DisplayAi();

                if (player.Health <= 0)
                {
                    points = points + 2;
                    player.Score.Add(points);

                    string Lost = (player.Name + " Slapped " + Ai.Name + " with a tuna and lost");
                    player.Battles.Add(Lost);

                    //Console.ReadKey();
                    Round.FinalStatistics(player, Ai);
                }
                //else if (player.Health > 0 && Ai.Health > 0)
                //{
                //    Round round = new Round(player, Ai);
                //}
                else if (Ai.Health <= 0)
                {
                    shopMoney = shopMoney + InfoGen.Next(2, 5);
                    player.ShopMoney.Add(shopMoney);

                    points = points + 5;
                    player.Score.Add(points);

                    string Lost = (player.Name + " Slapped " + Ai.Name + " with a trout and won");
                    player.Battles.Add(Lost);

                    //Console.ReadKey();
                    Program.Testing(player);
                }
                else
                {
                    Round.BattleSequence(player, Ai);
                }
            }
        //}

        public void DisplayAi()
        {
            Program.DisplayMessage(
                "Opponent: \n" +
                "Name: " + Name + "\n" +
                "Strength: " + Strength + "\n" +
                "Damage: " + Damage + "\n" +
                "Health: " + Health + "\n");
        }
    }
}

