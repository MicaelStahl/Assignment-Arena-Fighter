using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;

namespace Assignment_Arena_Fighter
{
    class Round
    {
        static InfoGenerator InfoGen = new InfoGenerator(DateTime.Now.Millisecond);

        public Character Player { get; set; }
        public Battle Ai { get; set; }



        public static void ScoreScreen(Character player, Battle Ai)
        {

            List<Battle> ScoreScreen = new List<Battle>();
            ScoreScreen.Add(Ai);

        }
    }
}
