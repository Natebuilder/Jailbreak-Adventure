using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jailbreak_Adventure
{
    public class gameOver
    {
        public static void gameOver1()
        {
            Console.WriteLine("Ewwww that was a disguisting move. Try again");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}"); 
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.gameTitle();
        }
        public static void gameOver2()
        {
            Console.WriteLine("Well that was a stupid dead someone just ate you like a snack. Try again");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score} "); 
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.gameTitle();
        }
        public static void gameOver3()
        {
            Console.WriteLine("Really you really thought that scanning the keycard while running");
            Console.WriteLine("When the cops watching the door you can surpass these cops!! Try again");
            Console.WriteLine($"Your final score is: {Program.Score}"); 
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.gameTitle();
        }
        public static void gameOver4()
        {
            Console.WriteLine("Well that was too bad next time don't try to sneak of you bad at it. Try Again");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}"); 
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.gameTitle();
        }
        public static void gameOver5()
        {
            Console.WriteLine("Well that was unexpected. Trick the cops ez trick the commissioner in your dreams.");
            Console.WriteLine("And your death is pathetic really get drown in the toilet!");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.gameTitle();
        }
        public static void gameOver6()
        {
            Console.WriteLine("Are you crazy. I mean I understand you want to escape,");
            Console.WriteLine("but really this way is way to worse. Its good you death!");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.gameTitle();
        }
        public static void gameOver7()
        {
            Console.WriteLine("That was a stupid move");
            Console.WriteLine("One of the cops are actually crazy\n and he used your death meat to his dog.");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.gameTitle();
        }
        public static void gameOver8()
        {
            Console.WriteLine("Well you tried, but maybe you should took a teammate to win this battle.");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.gameTitle();
        }
    }
}
