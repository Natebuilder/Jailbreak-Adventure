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
            Console.WriteLine("Your final score is: "); 
            Console.ReadLine();
            Console.Clear();
            Program.gameTitle();
        }
        public static void gameOver2()
        {
            Console.WriteLine("Well that was a stupid dead someone just ate you like a snack. Try again");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine("Your final score is: "); 
            Console.ReadLine();
            Console.Clear();
            Program.gameTitle();
        }
        public static void gameOver3()
        {
            Console.WriteLine("Really you really thought that scanning the keycard while running");
            Console.WriteLine("When the cops watching the door you can surpass these cops!! Try again");
            Console.WriteLine("Your final score is: "); 
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Program.gameTitle();
        }
        public static void gameOver4()
        {
            Console.WriteLine("Well that was too bad next time don't try to sneak of you bad at it. Try Again");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine("Your final score is: "); 
            Console.ReadLine();
            Console.Clear();
            Program.gameTitle();
        }
    }
}
