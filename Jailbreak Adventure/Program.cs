using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Jailbreak_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gametitle();
        }
        public static void gametitle()
        {
            Console.WriteLine("Jailbreak");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine("Type instructions to see instructions.");
            string word = Console.ReadLine();
            Console.Clear();
            
            while (word == "instructions")
            {
                Console.WriteLine("You are in prison. You have to escape it.");
                Console.WriteLine("Press enter to go back.");
                Console.ReadLine();
                Console.Clear();
                gametitle();
            }
            question1();
        }
        public static void question1()
        {
            string choice;
            Console.WriteLine("You are in prison. You want to escape it. You see a cop standing in the yard.");
            Console.WriteLine("What are you gonna do?.");
            Console.WriteLine("1. Punch him in the face.");
            Console.WriteLine("2. Act like a scary witch.");
            Console.WriteLine("3. Vomit in his face.");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "3":
                case "Vomit in face":
                case "Vomit":
                    {
                        Console.WriteLine("You vomit in the cop's face. He got angry and shoot in your head.");
                        Console.WriteLine("As result you are dead.");
                        Console.WriteLine("Press enter to continue!");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
            }
        }
        public static void gameOver()
        {
            Console.WriteLine("You are dead try again");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            gametitle();
        }
    }
}
