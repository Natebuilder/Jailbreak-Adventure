﻿using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Jailbreak_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
        }
        public static void gameTitle()
        {
            highScore.score();
            Console.WriteLine("Jailbreak");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine("Type instructions to see instructions.");
            string word = Console.ReadLine();
            Console.Clear();
        
            while (word == "instructions")
            {
                highScore.score();
                Console.WriteLine("You are in prison. You have to escape it.");
                Console.WriteLine("Press enter to go back.");
                Console.ReadLine();
                Console.Clear();
                gameTitle();
            }
            question.question1();
            question.question2();
        }
        
    }
}
