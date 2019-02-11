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
            DisplayMessage("\t\t" + @"                                      ______  _         _      _                ");
            DisplayMessage("\t\t" + @"     /\                              |  ____|(_)       | |    | |               ");
            DisplayMessage("\t\t" + @"    /  \    _ __  ___  _ __    __ _  | |__    _   __ _ | |__  | |_  ___  _ __   ");
            DisplayMessage("\t\t" + @"   / /\ \  | '__|/ _ \| '_ \  / _` | |  __|  | | / _` || '_ \ | __|/ _ \| '__|  ");
            DisplayMessage("\t\t" + @"  / ____ \ | |  |  __/| | | || (_| | | |     | || (_| || | | || |_|  __/| |     ");
            DisplayMessage("\t\t" + @" /_/    \_\|_|   \___||_| |_| \__,_|_|_|     |_| \__, ||_| |_| \__|\___||_|     ");
            DisplayMessage("\t\t" + @"                                 |___ \           __/ |                         ");
            DisplayMessage("\t\t" + @"                                   __) |         |___/                          ");
            DisplayMessage("\t\t" + @"                                  |__ <                                         ");
            DisplayMessage("\t\t" + @"                                  ___) |                                        ");
            DisplayMessage("\t\t" + @"                                 |____/                                         ");

            Character player = CreatePlayer();


            Testing(player);
        }
        public static void Testing(Character player)
        {
            int shopMoney = 0;

            Battle Ai = CreateAi();

            bool stayAlive = true;

            while (stayAlive)
            {

                Console.Clear();
                player.DisplayPlayer();

                Console.Write(
                    "What do you want to do?\n" +
                    "H - Hunt for a pray! \n" +
                    "S - Go to the shop! \n" +
                    "F - Flee like a cooooooward! \n");
                char playerChoice = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (playerChoice)
                {
                    case 'H':
                        NewFighters(player, Ai);
                        stayAlive = false;
                        break;
                    case 'S':
                        ArenaShop(player, Ai, shopMoney);
                        break;
                    case 'F':
                        Round.FinalStatistics(player, Ai);
                        stayAlive = false;
                        break;
                    default:
                        DisplayMessage("Incorrect input", ConsoleColor.Red);
                        Console.ReadKey();

                        break;
                }
            }
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

        public static Round NewFighters(Character player, Battle Ai)
        {
            return new Round(player, Ai);

        }
        /// <summary>
        /// Asks the user for a character name to use in the game
        /// </summary>
        static string AskUserForThings(string x)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n\n\t\t\t\tPlease write your " + x + ": ");
            string playerName = Console.ReadLine();

            return playerName;
        }
        /// <summary>
        /// Just a humble shop that gives the player the opportunity to upgrade his/her stats
        /// </summary>
        public static void ArenaShop(Character player, Battle Ai, int shopMoney)
        {
            bool stayAlive = true;

            shopMoney = 0;

            foreach (int points in player.ShopMoney)
            {
                shopMoney = shopMoney + points;
            }

            while (stayAlive)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;

                player.DisplayPlayer();

                DisplayMessage(
                    "Hello and welcome to my humble shop! Have a look at my wares! (You have: " + shopMoney + " coins!)" + "\n\n" +
                    "(S)trength - 3 coins - 'I want to train to get stronger!' *weird flex but okay...* (gives 1 Strength points)\n" +
                    "(D)amage - 2 coins - 'I demand your sharpest sword!' *Gives user a copper shortsword* (gives 1 Damage points)\n" +
                    "(H)ealth - 5 coins - 'Potion Seller, I desire only your strongest potions!' (gives +5 current Health points)\n\n" +
                    "(B)ack - 0 coins - If you want to go back to the arena!\n"
                );
                DisplayMessage("Beware brave fighter, thy your choices will significantly strengthen your opponents temporarily!\n", ConsoleColor.Yellow);

                char choice = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (choice)
                {
                    case 'S':
                        Console.Clear();
                        AddStrength(player, Ai, shopMoney);

                        if (shopMoney >= 3)
                        {
                            shopMoney = shopMoney - 3;
                        }
                        break;
                    case 'D':
                        Console.Clear();
                        AddDamage(player, Ai, shopMoney);

                        if (shopMoney >= 2)
                        {
                            shopMoney = shopMoney - 2;
                        }
                        break;
                    case 'H':
                        Console.Clear();
                        AddHealth(player, Ai, shopMoney);

                        if (shopMoney >= 5)
                        {
                            shopMoney = shopMoney - 5;
                        }
                        break;

                    case 'B':
                        stayAlive = false;
                        break;

                    default:
                        DisplayMessage("Oh, dear fighter, I'm afraid that isn't an option in this humble shop!", ConsoleColor.Red);
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void AddStrength(Character player, Battle Ai, int shopMoney)
        {
            if (shopMoney >= 3)
            {
                player.ShopMoney.Add(-3);
                Program.DisplayMessage(
                "\nPlayer: \n" +
                "Name: " + player.Name + "\n" +
                "Strength: " + player.Strength + " + 1" + "\n" +
                "Damage: " + player.Damage + "\n" +
                "Health: " + player.Health + "\n");

                player.Strength = player.Strength + 1;
                Ai.Strength = Ai.Strength + 3;

                DisplayMessage("Thank you for your purchase!", ConsoleColor.Green);
                Console.ReadKey();
            }
            else
            {
                DisplayMessage("Get out of here you poor scoundrel before I stab you!", ConsoleColor.Red);
                Console.ReadKey();
            }
        }

        public static void AddDamage(Character player, Battle Ai, int shopMoney)
        {
            if (shopMoney >= 2)
            {
                Program.DisplayMessage(
                "\nPlayer: \n" +
                "Name: " + player.Name + "\n" +
                "Strength: " + player.Strength + "\n" +
                "Damage: " + player.Damage + " + 1" + "\n" +
                "Health: " + player.Health + "\n");

                player.Damage = player.Damage + 1;
                Ai.Damage = Ai.Damage + 50;

                DisplayMessage("Thank you for your purchase!", ConsoleColor.Green);
                Console.ReadKey();
            }
            else
            {
                DisplayMessage("Get out of here you poor scoundrel before I stab you!", ConsoleColor.Red);
                Console.ReadKey();
            }
        }

        public static void AddHealth(Character player, Battle Ai, int shopMoney)
        {
            if (shopMoney >= 5)
            {
                Program.DisplayMessage(
                "\nPlayer: \n" +
                "Name: " + player.Name + "\n" +
                "Strength: " + player.Strength + "\n" +
                "Damage: " + player.Damage + "\n" +
                "Health: " + player.Health + " + 5" + "\n");

                player.Health = player.Health + 5;
                Ai.Health = Ai.Health + 20;

                DisplayMessage("Thank you for your purchase!", ConsoleColor.Green);
                Console.ReadKey();
            }
            else
            {
                DisplayMessage("Get out of here you poor scoundrel before I stab you!", ConsoleColor.Red);
                Console.ReadKey();
            }
        }

        /// <summary>
        ///This simple method works a bit like a Console.WriteLine but with the option to add colors. example: ("blah", Consolecolor.Red);
        /// </summary>

        public static void DisplayMessage(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
