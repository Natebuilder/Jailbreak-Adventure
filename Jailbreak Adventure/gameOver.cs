using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jailbreak_Adventure
{
    public class GameOver
    {
        public static void GameOver1()
        {
            Console.WriteLine("Ewwww that was a disguisting move. Try again");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}"); 
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
        public static void GameOver2()
        {
            Console.WriteLine("Well that was a stupid dead someone just ate you like a snack. Try again");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score} "); 
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
        public static void GameOver3()
        {
            Console.WriteLine("Really you really thought that scanning the keycard while running");
            Console.WriteLine("When the cops watching the door you can surpass these cops!! Try again");
            Console.WriteLine($"Your final score is: {Program.Score}"); 
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
        public static void GameOver4()
        {
            Console.WriteLine("Well that was too bad next time don't try to sneak of you bad at it. Try Again");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}"); 
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
        public static void GameOver5()
        {
            Console.WriteLine("Well that was unexpected. Trick the cops ez trick the commissioner in your dreams.");
            Console.WriteLine("And your death is pathetic really get drown in the toilet!");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
        public static void GameOver6()
        {
            Console.WriteLine("Are you crazy. I mean I understand you want to escape,");
            Console.WriteLine("but really this way is way to worse. Its good you death!");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
        public static void GameOver7()
        {
            Console.WriteLine("That was a stupid move");
            Console.WriteLine("One of the cops is actually crazy\n and he used your death meat to his dog.");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
        public static void GameOver8()
        {
            Console.WriteLine("Well you tried, but maybe you should took a teammate to win this battle.");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
        public static void GameOver9()
        {
            Console.WriteLine("Wow next time think twice before you waste this move.");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
        public static void GameOver10()
        {
            Console.WriteLine("You shouldn't do that this is just way too stupid.");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
    }
}
