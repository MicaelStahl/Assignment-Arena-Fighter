using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;



namespace Assignment_Arena_Fighter
{
    class Character
    {
        static InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);

        public Character()
        {
        }
        public string playerName { get; set; }
        public int playerStrength;
        public int playerDamage;
        public int playerHealth;

        public string AiName { get; set; }
        public int AiStrength;
        public int AiDamage;
        public int AiHealth;
        


        public Character(string playerName, int playerStrength, int playerDamage, int playerHealth)
        {
            this.playerName = playerName;
            this.playerStrength = playerStrength;
            this.playerDamage = playerDamage;
            this.playerHealth = playerHealth;


   
        }
        public Character(int AiStrength, int AiDamage, int AiHealth)
        {
            this.AiName = infoGen.NextFirstName();
            this.AiStrength = AiStrength;
            this.AiDamage = AiDamage;
            this.AiHealth = AiHealth;
            DisplayOpponent();
            //Console.WriteLine("\nAiName = " + AiName);
            //Console.WriteLine("AiStrength = " + AiStrength);
            //Console.WriteLine("AiDamage = " + AiDamage);
            //Console.WriteLine("AiHealth = " + AiHealth);

        }
        public void DisplayPlayer() //Change this name sometime in the future {
        {
            Console.WriteLine(
                "Name: " + playerName + "\n" +
                "Strength: " + playerStrength + "\n" +
                "Damage: " + playerDamage + "\n" +
                "Health: " + playerHealth);

        }
        public void DisplayOpponent()
        {
            Console.WriteLine(
                "Name: " + AiName + "\n" +
                "Strength: " + AiStrength + "\n" +
                "Damage: " + AiDamage + "\n" +
                "Health: " + AiHealth);
        }

        //public Character(int AiStrength, int AiDamage, int AiHealth)
        //{

        //    this.AiStrength = AiStrength;
        //    this.AiDamage = AiDamage;
        //    this.AiHealth = AiHealth;

        //    Console.WriteLine("\n" +
        //        "Name: " + AiName + "\n" +
        //        "Strength: " + AiStrength + "\n" +
        //        "Damage: " + AiDamage + "\n" +
        //        "Health: " + AiHealth);
        //}
    }
}
