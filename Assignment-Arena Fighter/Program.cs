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

            //bool stayAlive = true;
            DisplayMessage(
                "--- Welcome to Assignment 3 ---\n" +
                "\tArena Fighter\n", ConsoleColor.DarkMagenta
                );
            /**while (stayAlive)
            {

                Console.Write("Would you like to create a character? y/n");
                char choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case 'y':
                        Console.Clear();
                        
                        break;
                    case 'n':
                        stayAlive = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid option, try again.");
                        break;
                }
            }*/

            TestingGrounds();


        }

        static void TestingGrounds()
        {

            Battle Ai = CreateAi();

            Character player = CreatePlayer();

            ReturnFighters(player, Ai);

        }

        public static Battle CreateAi()
        {
            return new Battle(InfoGen.NextFirstName(Gender.Any), InfoGen.Next(1, 9), InfoGen.Next(1, 9), InfoGen.Next(1, 9));
        }

        public static Character CreatePlayer()
        {
            string CharName = AskUserForThings("Character name");

            return new Character(CharName, InfoGen.Next(1, 9), InfoGen.Next(1, 6), InfoGen.Next(2, 9)); //Sends name, strength, damage and health to a constructor in Character class
        }

        public static Battle ReturnFighters(Character player, Battle Ai)
        {
            return new Battle(player, Ai);

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
