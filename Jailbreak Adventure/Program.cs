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

                string action = Console.ReadLine();

                if (action == "walk")
                {
                    Console.WriteLine("You walked into the cop. The cop saw you try to steal the keycard.");
                    Console.ReadLine();
                    Console.WriteLine("As punishedment you are back in your cel.");
                    Console.ReadLine();
                }
                if (action == "run")
                {
                    Console.WriteLine("You ran into the cop. You were so fast that the cop didn't know you stole his keycard.");
                    Console.ReadLine();
                    Console.WriteLine("You are running away with the keycard.");
                    Console.ReadLine();
                    Console.WriteLine("The cop is chasing you.");
                    Console.WriteLine("What are you gonna do?");
                }
                if (action == "punch")
                {
                    Console.WriteLine("You tried to punch the cop. Too bad the cop dodged it. You are arrested.");
                    Console.ReadLine();
                    Console.WriteLine("As punishedment you are back in your cel.");
                    Console.ReadLine();
                }
                if (action == "kick")
                {
                    Console.WriteLine("You kicked the cop knock out and ran away with the keycard.");
                    Console.ReadLine();
                    Console.WriteLine("Other cops saw it and run to you.");
                    Console.WriteLine("What are you gonna do?");
                    Console.ReadLine();
                }
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