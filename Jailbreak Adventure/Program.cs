using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Jailbreak_Adventure
{
    internal class Program
    {   
        //Basically the score of this game.
        public static int Score = 0;
        static void Main(string[] args)
        {
            //Runs the game.
            GameTitle();
        }
        //In this method is the whole game.
        public static void GameTitle()
        {
            //This code shows the current score of the player.
            Console.WriteLine($"Score: {Score}\n");

            //This is the game menu.
            Console.WriteLine("Jailbreak");
            Console.WriteLine("Press enter to continue.");

            //If you type instructions the string word will go to a while loop.
            Console.WriteLine("Type instructions to see instructions.");
            string word = Console.ReadLine();
            Console.Clear();
            
            //This is the while loop for instructions. This is while loop will send you here if word is equal to instructions.
            while (word == "instructions")
            {
                //Here are some simple instructions of this game.
                Console.WriteLine("You are in prison. You have to escape it. If you forgot how to play type help.");
                Console.WriteLine("Press enter to go back.");
                Console.ReadLine();
                Console.Clear();

                //You are send back to the begin screen.
                GameTitle();
            }
            //This are all questions.
            Question.Question1();
            Question.Question2();
            Question.Question3();
            Question.Question4();
            Question.Question5();
        }
    }
}
