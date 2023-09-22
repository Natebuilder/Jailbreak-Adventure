using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jailbreak_Adventure
{
    public class Congrats
    {
        public static void Congrats1()
        {
            Console.WriteLine("Congratulations you escaped the prison.");
            Console.WriteLine("Thanks for playing my game.");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine($"Your final score is: {Program.Score}");
            Console.ReadLine();
            Console.Clear();
            Program.Score = 0;
            Program.GameTitle();
        }
    }
}
