﻿using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Jailbreak_Adventure
{
    internal class Program
    {
        public static int Score = 0;
        static void Main(string[] args)
        {
            gameTitle();
        }
        public static void gameTitle()
        {
            Console.WriteLine($"Score: {Score}\n");
            Console.WriteLine("Jailbreak");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine("Type instructions to see instructions.");
            string word = Console.ReadLine();
            Console.Clear();
        
            while (word == "instructions")
            {
                Console.WriteLine("You are in prison. You have to escape it. If you forgot how to play type help.");
                Console.WriteLine("Press enter to go back.");
                Console.ReadLine();
                Console.Clear();
                gameTitle();
            }
            question.question1();
            question.question2();
            question.question3();
            question.question4();
            question.question5();
        }
    }
}
