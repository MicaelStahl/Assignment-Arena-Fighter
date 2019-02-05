using System;
using System.Collections.Generic;
using Lexicon.CSharp.InfoGenerator;

namespace Assignment_Arena_Fighter
{
    class Program
    {
        public static InfoGenerator InfoGen = new InfoGenerator(DateTime.Now.Millisecond);

        static void Main(string[] args)
        {
            DisplayMessage("\n\t\t\t\t\t--- Welcome to Assignment 3 ---\n" + "\t\t\t\t\t\tArena Fighter\n", ConsoleColor.Yellow);
            Character player = CreatePlayer();

            Testing(player);
        }
        public static void Testing(Character player)
        {
            int shopMoney = 0;

            Battle Ai = CreateAi();

            //bool stayAlive = true;

            Console.Clear();
            player.DisplayPlayer();

            //while (stayAlive)
            //{

            Console.Write(
                "What do you want to do?\n" +
                "H - Hunt for a pray! \n" +
                "S - Go to the shop! \n" +
                "F - Flee like a cooooooward! \n");
            char playerChoice = Console.ReadKey(true).KeyChar;
            switch (playerChoice)
            {
                case 'h':
                    ReturnFighters(player, Ai);
                    break;
                case 's':
                    ArenaShop(player, shopMoney);
                    break;
                case 'f':
                    Round.FinalStatistics(player, Ai);
                    //stayAlive = false;
                    break;
                default:
                    DisplayMessage("Incorrect input", ConsoleColor.Red);
                    break;
            }
            //}
        }

        public static Battle CreateAi()
        {
            return new Battle(InfoGen.NextFirstName(), InfoGen.Next(5, 15), InfoGen.Next(5, 8), InfoGen.Next(5, 15));
        }

        public static Character CreatePlayer()
        {
            string playerName = AskUserForThings("Character name");

            return new Character(playerName, InfoGen.Next(5, 15), InfoGen.Next(5, 8), InfoGen.Next(5, 15)); //Sends name, strength, damage and health to a constructor in Character class
        }

        public static Round ReturnFighters(Character player, Battle Ai)
        {
            return new Round(player, Ai);

        }

        static string AskUserForThings(string x)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please write your " + x + ": ");
            string playerName = Console.ReadLine();

            return playerName;
        }

        public static void ArenaShop(Character player, int shopMoney)
        {
            //bool stayAlive = true;

            //int shopMoney = 0;
            Console.Clear();


            //while (stayAlive)
            //{

            foreach (int points in player.ShopMoney)
            {
                shopMoney = points;
            }
            Console.ForegroundColor = ConsoleColor.White;

            player.DisplayPlayer();

            DisplayMessage(
                "Hello and welcome to my shop! Have a look at my wares! (You have: " + shopMoney + " coins!)" + "\n\n" +
                "(S)trength - 3 coins - 'I want to train to get stronger!' *weird flex but okay...* (gives 1 Strength points)\n" +
                "(D)amage - 2 coins - 'I demand your sharpest sword!'*Gives user a copper shortsword* (gives 1 Damage points\n" +
                "(H)ealth - 5 coins - 'Potion Seller, I want only your strongest potions!' (gives +5 current Health points\n" +
                "(L)augh - 1 coin - For a fun surprise!\n" +
                "(B)ack - 0 coins - If you want to go back to the arena!\n"
            );

            char choice = char.ToUpper(Console.ReadKey(true).KeyChar);

            switch (choice)
            {
                case 'S':
                    Console.Clear();
                    AddStrength(player, shopMoney);
                    break;
                case 'D':
                    AddDamage(player, shopMoney);
                    break;
                case 'H':
                    AddHealth(player, shopMoney);
                    break;
                case 'L':
                    LlamaTime(player, shopMoney);
                    break;

                case 'B':
                    Testing(player);
                    break;

            }
            Console.ReadKey();

            //}

        }

        public static void AddStrength(Character player, int shopMoney)
        {
            if (shopMoney >= 3)
            {
                player.playerStrength = player.playerStrength + 1;
                shopMoney = shopMoney - 3;
                player.ShopMoney.Add(shopMoney);

                DisplayMessage("Thank you for your purchase!", ConsoleColor.Green);

                ArenaShop(player, shopMoney);
            }
            else
            {
                DisplayMessage("Get out of here you poor scoundrel!", ConsoleColor.Red);
                ArenaShop(player, shopMoney);
            }
        }

        public static void AddDamage(Character player, int shopMoney)
        {
            if (shopMoney >= 2)
            {
                player.playerDamage = player.playerDamage + 1;
                shopMoney = shopMoney - 2;
                player.ShopMoney.Add(shopMoney);

                DisplayMessage("Thank you for your purchase!", ConsoleColor.Green);

                ArenaShop(player, shopMoney);
            }
            else
            {
                DisplayMessage("Get out of here you poor scoundrel!", ConsoleColor.Red);
                ArenaShop(player, shopMoney);
            }
        }

        public static void AddHealth(Character player, int shopMoney)
        {
            if (shopMoney >= 5)
            {
                player.playerHealth = player.playerHealth + 5;
                shopMoney = shopMoney - 5;
                player.ShopMoney.Add(shopMoney);

                DisplayMessage("Thank you for your purchase!", ConsoleColor.Green);

                ArenaShop(player, shopMoney);
            }
            else
            {
                DisplayMessage("Get out of here you poor scoundrel!", ConsoleColor.Red);
                ArenaShop(player, shopMoney);
            }
        }

        public static void LlamaTime(Character player, int shopMoney)
        {

        }

        /// <summary>
        ///This simple method works a bit like a Console.WriteLine but with the option to add colors. example: ("blah", Consolecolor.Red);
        /// </summary>

        public static void DisplayMessage(string message, ConsoleColor color = ConsoleColor.White)
        {
            // This simple method works a bit like a Console.WriteLine and also saves unnecessary lines of code
            // for Console.ForeGroundColor, Console.ResetColor etc.
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
