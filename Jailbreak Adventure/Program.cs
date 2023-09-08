namespace Jailbreak_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jailbreak");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Type 1 to play!!");
            Console.WriteLine("Type 2 for options to see the options you can use.");

            int number = int.Parse(Console.ReadLine());
            string walk;
            string run;
            string punch;
            string kick;

            if (number == 1)
            {
                Console.WriteLine("Welcome to Jailbreak to start this game you have to escape prison!!");
                Console.ReadLine();
                Console.WriteLine("Your first goal is to escape the prison.");
                Console.ReadLine();
                Console.WriteLine("You are in the yard of the prison.");
                Console.ReadLine();
                Console.WriteLine("You want to steal a keycard of a cop.");
                Console.WriteLine("What are you gonna do?");
                Console.ReadLine();

            }
            if (number == 2)
            {
                Console.WriteLine("Here are the possible options for this game");
                Console.WriteLine("walk");
                Console.WriteLine("run");
                Console.WriteLine("punch");
                Console.WriteLine("kick");
            }
        }
    }
}