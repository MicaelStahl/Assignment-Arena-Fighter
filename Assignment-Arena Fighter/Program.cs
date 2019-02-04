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
            DisplayMessage("--- Welcome to Assignment 3 ---\n" + "\tArena Fighter\n", ConsoleColor.DarkMagenta);

            Testing();
        }
        public static void Testing(bool stayAlive = true)
        {
            //bool stayAlive = true;
            while (stayAlive)
            {

            Console.Write("Would you like to create a character? y/n \n");
            char choice = Console.ReadKey(true).KeyChar;

            switch (choice)
            {
                case 'y':
                    //while (stayAlive)
                    //{

                        Console.Clear();
                        Character player = CreatePlayer();
                        player.DisplayPlayer();

                        Console.Write(
                            "What do you want to do?\n" +
                            "H - Hunt for a pray! \n" +
                            "F - Flee like a cooooooward! \n");
                        char playerChoice = Console.ReadKey(true).KeyChar;
                        switch (playerChoice)
                        {
                            case 'h':
                                TestingGrounds(player);
                                stayAlive = false;
                                break;
                            case 'f':
                                stayAlive = false;
                                break;
                            default:
                                DisplayMessage("Incorrect input", ConsoleColor.Red);
                                break;
                        }
                    //}
                    break;
                case 'n':
                    //stayAlive = false;
                    break;
                default:
                    Console.Clear();

                    //Console.WriteLine("Not a valid option, try again.");
                    break;
            }
            }
        }

        public static void TestingGrounds(Character player)
        {


            Battle Ai = CreateAi();

            ReturnFighters(player, Ai);

        }

        public static Battle CreateAi()
        {
            return new Battle(InfoGen.NextFirstName(), InfoGen.Next(1, 9), InfoGen.Next(1, 9), InfoGen.Next(1, 9));
        }

        public static Character CreatePlayer()
        {
            string playerName = AskUserForThings("Character name");

            return new Character(playerName, InfoGen.Next(1, 9), InfoGen.Next(1, 6), InfoGen.Next(2, 9)); //Sends name, strength, damage and health to a constructor in Character class
        }

        public static Round ReturnFighters(Character player, Battle Ai)
        {
            return new Round(player, Ai);

        }

        static string AskUserForThings(string x)
        {
            Console.Write("Please write your " + x + ": ");
            string CharName = Console.ReadLine();

            return CharName;
        }
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
