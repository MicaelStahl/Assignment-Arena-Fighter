using System;
using System.Collections.Generic;
using Lexicon.CSharp.InfoGenerator;
namespace Assignment_Arena_Fighter
{
    class Program
    {
        public static InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);

        static void Main(string[] args)
        {

            //bool stayAlive = true;
            //Console.WriteLine(
            //    "--- Welcome to Assignment 3 ---\n" +
            //    "\tArena Fighter\n"
            //    );
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
            Character opponent = Battle.CreateOpponent();

        }
        //public Battle CreateOpponent()
        //{
        //    Battle opponent = CreateOpponent();
        //    Character player = CreatePlayer();
        //    return new Battle(player, opponent);
        //}
        static void TestingGrounds()
        {
            //bool stayAlive = true;


            //Console.Write(
            //    "\nWhat would you like to do?\n" +
            //    "F - Fight an opponent\n" +
            //    "R - Run away like a coward\n"
            //    );
            char choice = Console.ReadKey(true).KeyChar;
            

            //player.DisplayPlayer();
        }
        static Character CreatePlayer()
        {
            string CharName = AskUserForThings("Character name");

            return new Character(CharName, infoGen.Next(1,9), infoGen.Next(1, 6), infoGen.Next(2, 9)); //Sends name, strength, damage and health to a constructor in Character class
        }

        static string AskUserForThings(string x)
        {
            Console.Write("Please write your " + x + ": ");
            string CharName = Console.ReadLine();

            return CharName;
        }

        //static int AskUserForNumberThings(string x)
        //{
        //    Console.Write("Please write your " + x + " value:");
        //    int number = int.Parse(Console.ReadLine());

        //    return number;
        //}

    }
}
