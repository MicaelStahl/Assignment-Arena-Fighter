using System;
using System.Collections.Generic;
using Lexicon.CSharp.InfoGenerator;
namespace Assignment_Arena_Fighter
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCharacter();
        }
        static Character CreateCharacter()
        {
            string CharName = AskUserForThings("Character name");
            int CharStrength = AskUserForNumberThings("Strength");
            int CharDamage = AskUserForNumberThings("Damage");
            int CharHealth = AskUserForNumberThings("Health");

            return new Character(CharName, CharStrength, CharDamage, CharHealth);
        }
        static string AskUserForThings(string x)
        {
            Console.Write("Please write your " + x + ": ");
            string CharName = Console.ReadLine();

            return CharName;
        }
        static int AskUserForNumberThings(string x)
        {
            Console.Write("Please write your " + x + " value:");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
    }
}
