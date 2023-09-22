using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jailbreak_Adventure
{
    public class Question
    {
        //This is the first question you have to find a way to steal a keycard from a cop.
        public static void Question1()
        {
            string choice = "_";
            //This do while loop checks if the player fill 1, 2 or 3 in if it is something else the get a message and get send back to the question.
            do
            {
                //This is the controller that checks what the player filled.
                if (choice != "_")
                {
                    Console.WriteLine($"Hey! {choice} this choice isn't not in the list!");
                }
                //This code shows the current score of the player.
                Console.WriteLine($"Score: {Program.Score}\n");

                //This is the whole question with options the player can choose from.
                Console.WriteLine("You are in prison. You want to escape it. You see a cop standing in the yard.");
                Console.WriteLine("What are you gonna do?.");
                Console.WriteLine("1. Punch him in the face.");
                Console.WriteLine("2. Act like a scary witch.");
                Console.WriteLine("3. Vomit in his face.");

                //The player choose an option and it will send to a switch.
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();

                Console.Clear();

                //This if statement send the player to help it should help the player how to play the game.
                if (choice == "help")
                {
                    Help.Help1();
                    Question1();
                }

                //This switch checks the player's choice. Every question have 2 bad endings and 1 good ending. In this switch option 1 is good and the other 2 are bad.
                //The first option you are sending to the next question the other 2 you get 2 different gameovers.
                switch (choice)
                {
                    case "1":
                    case "Punch him in face":
                    case "Punch face":
                        {
                            //This gives the player 100 points, because it was the right answer.
                            Program.Score += 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You punched the cop in the face.");
                            Console.WriteLine("As result the cop is knockout and you stole his keycard.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            Question2();
                            break;
                        }
                    case "2":
                    case "Act like a scary witch":
                    case "Scary Witch":
                        {
                            //This code gives the player -100 points, because it was a wrong answer.
                            Program.Score -= 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You act like a scary witch in front of a cop.");
                            Console.WriteLine("Too bad your acting is bad and the cop knock you out.");
                            Console.WriteLine("Meanwhile an another prison got hungry and he ate you!!");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver.GameOver2();
                            break;
                        }
                    case "3":
                    case "Vomit in face":
                    case "Vomit face":
                        {
                            //This code gives the player -100 points, because it was a wrong answer.
                            Program.Score -= 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You vomit in the cop's face. He got angry and shoot in your head.");
                            Console.WriteLine("As result you are dead.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver.GameOver1();
                            break;
                        }
                }
              //This is a part of the do while loop that checks if the player type 1, 2 or 3 in.
            } while (choice != "1" && choice != "2" && choice != "3");
        }

        //This is the question 2. You stole the keycard and 2 cops are blocking the door by the police station. Find a way to surpass them.
        //This question and the first question has the same format. The difference is other situation other options. If you want to know
        //what the code does go back to question 1.
        public static void Question2()
        {

            string choice = "_";

            do
            {
                if (choice != "_")
                {
                    Console.WriteLine($"Hey! {choice} this choice isn't not in the list!");
                }

                Console.WriteLine($"Score: {Program.Score}\n");
                Console.WriteLine("You stole the keycard. 2 cops are watching the door by the police station.");
                Console.WriteLine("What are you gonna do?.");
                Console.WriteLine("1. Run to the door.");
                Console.WriteLine("2. Sneak on the cops and knock them out.");
                Console.WriteLine("3. Try to find an another cop.");
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();

                Console.Clear();

                if (choice == "help")
                {
                    Help.Help1();
                    Question2();
                }

                switch (choice)
                {
                    case "1":
                    case "Run to the door":
                    case "Run door":
                        {
                            Program.Score -= 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You tried to run to the door.");
                            Console.WriteLine("A brutal cop saw you and he hit you in the face.");
                            Console.WriteLine("the blood spurts out your nose and you are bleeding to dead.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver.GameOver3();
                            break;
                        }
                    case "2":
                    case "Sneak on the cops":
                    case "Sneak cops":
                        {
                            Program.Score -= 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You try to sneak on the cops.");
                            Console.WriteLine("Too bad you sneak skills is too loud!");
                            Console.WriteLine("The cops heard you and caught you!");
                            Console.WriteLine("They thought you want freedom so they threw you in the river tied up");
                            Console.WriteLine("You can't escape and you are drowning to dead!");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver.GameOver4();
                            break;
                        }
                    case "3":
                    case "Try to find cop":
                    case "Another Cop":
                        {
                            Program.Score += 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You were searching for an another cop.");
                            Console.WriteLine("One of sleeping by the prison.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            Question3();
                            break;
                        }
                }
            } while (choice != "1" && choice != "2" && choice != "3");
        }

        //You made it to the 3rd question. You found a cop that sleeps what are you gonna do?
        //This question have the same format as the other ones go back to question 1 to know what the code does.
        public static void Question3()
        {
            string choice = "_";

            do
            {
                if (choice != "_")
                {
                    Console.WriteLine($"Hey! {choice} this choice isn't not in the list!");
                }

                Console.WriteLine($"Score: {Program.Score}\n");
                Console.WriteLine("You found a sleeping cop. No other cops knows that.");
                Console.WriteLine("What are you gonna do to that cop?");
                Console.WriteLine("1. Steal his clothes and go undercover.");
                Console.WriteLine("2. Kill the cop and threat the other cops.");
                Console.WriteLine("3. Steal his gun");
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();

                Console.Clear();
                if (choice == "help")
                {
                    Help.Help1();
                    Question3();
                }

                switch (choice)
                {
                    case "1":
                    case "Steal clothes from cop":
                    case "Steal clothes":
                        {
                            Program.Score -= 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You stole the cops clothes.");
                            Console.WriteLine("The commissioner saw it on security cameras.");
                            Console.WriteLine("As result you are arrested by the commissioner.");
                            Console.WriteLine("The commissioner place you to a maximum security prison.");
                            Console.WriteLine("The new prisoners there don't like you and they drown you in the toilet.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver.GameOver5();
                            break;
                        }
                    case "2":
                    case "Kill the cop":
                    case "Kill cop":
                        {
                            Program.Score -= 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You punched the cop's head off.");
                            Console.WriteLine("You walk to the other cops With a disgusting head.");
                            Console.WriteLine("You threat like if you don't let me go this will happen to you.");
                            Console.WriteLine("The other cops aren't scared and that shoot you to death");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver.GameOver6();
                            break;
                        }
                    case "3":
                    case "Steal his gun":
                    case "Steal gun":
                        {
                            Program.Score += 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You stole the gun from the cop.");
                            Console.WriteLine("The other 2 cops tried to shoot you down.");
                            Console.WriteLine("You shoot the 2 cops down and you use your keycard.");
                            Console.WriteLine("And you go in the police station.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            Question4();
                            break;
                        }
                }
            } while (choice != "1" && choice != "2" && choice != "3");
        }

        //Wow question 4 lets go. You are in the police station surrounded by cops. Find a way to win in this situation.
        //This question have the same format as the other ones go back to question 1 to know what the code does.
        public static void Question4()
        {
            string choice = "_";

            do
            {
                if (choice != "_")
                {
                    Console.WriteLine($"Hey! {choice} this choice isn't not in the list!");
                }
                Console.WriteLine($"Score: {Program.Score}\n");
                Console.WriteLine("You are on the 1st floor of the police station.");
                Console.WriteLine("You are surrounded by 5 cops 2 left 2 right and 1 in front of you.");
                Console.WriteLine("They give you a chance to surrender.");
                Console.WriteLine("What is your move in this situation?");
                Console.WriteLine("1. You surrender.");
                Console.WriteLine("2. Shoot left.");
                Console.WriteLine("3. Shoot right.");
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();

                Console.Clear();

                if (choice == "help")
                {
                    Help.Help1();
                    Question4();
                }

                switch (choice)
                {
                    case "1":
                    case "You surrender":
                    case "You surrender.A":
                        {
                            Program.Score += 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You surrender to the cops.");
                            Console.WriteLine("You are hiding your gun behind your back.");
                            Console.WriteLine("One of the cops will bring back to your prison.");
                            Console.WriteLine("Meanwhile before the cop had the chance to grab you you shoot him down.");
                            Console.WriteLine("The other cops start shooting while you found cover for the bullets.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            Question5();
                            break;
                        }
                    case "2":
                    case "Shoot left":
                    case "Shoot left.A":
                        {
                            Program.Score -= 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You tried to shoot left, but you forgot to pull off the trigger.");
                            Console.WriteLine("The other cops shoot you death.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver.GameOver7();
                            break;
                        }
                    case "3":
                    case "Shoot right":
                    case "Shoot right.A":
                        {
                            Program.Score -= 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You shoot right and you shoot 2 cops in the head.");
                            Console.WriteLine("You don't have the speed to take down the other cops.");
                            Console.WriteLine("They shoot you death.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver.GameOver8();
                            break;
                        }
                }
            } while (choice != "1" && choice != "2" && choice != "3");
        }

        //You made it to the last question. You found cover, but you stuck because the cops keep shooting.
        //In the police station you found a grenade. Choose the right spot to use this grenade.
        //This question have the same format as the other ones go back to question 1 to know what the code does.
        public static void Question5()
        {
            string choice = "_";

            do
            {
                if (choice != "_")
                {
                    Console.WriteLine($"Hey! {choice} this choice isn't not in the list!");
                }
                Console.WriteLine($"Score: {Program.Score}\n");
                Console.WriteLine("You are stuck because the cops keep shooting.");
                Console.WriteLine("While being stuck you found a grenade in the police station.");
                Console.WriteLine("What are you gonna do with this grenade?");
                Console.WriteLine("1. Throw it to the cops.");
                Console.WriteLine("2. Threat the cops with it.");
                Console.WriteLine("3. Throw it to the stairs.");
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();

                Console.Clear();

                if (choice == "help")
                {
                    Help.Help1();
                    Question5();
                }

                switch (choice)
                {
                    case "1":
                    case "Throw it to cops":
                    case "Throw cops":
                        {
                            Program.Score -= 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You threw the grenade to the cops.");
                            Console.WriteLine("You are hiding your gun behind your back.");
                            Console.WriteLine("All the cops are death, but the commisioner shoot you to death.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver.GameOver9();
                            break;
                        }
                    case "2":
                    case "Threat the cops":
                    case "Threat cops":
                        {
                            Program.Score -= 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You threat the cops with the grenade.");
                            Console.WriteLine("One of the cops shoot in the grenade.");
                            Console.WriteLine("The grenade explode and you death.");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver.GameOver10();
                            break;
                        }
                    case "3":
                    case "Throw it to stairs":
                    case "Throw stairs":
                        {
                            Program.Score += 100;
                            Console.WriteLine($"Score: {Program.Score}\n");
                            Console.WriteLine("You throw it to the stairs.");
                            Console.WriteLine("When the grenade explode the wall of the police station breaks.");
                            Console.WriteLine("Meanwhile you have enough cover, because there is too much smoke.");
                            Console.WriteLine("You stole a police car and break to the fence!");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadLine();
                            Console.Clear();
                            Congrats.Congrats1();
                            break;
                        }
                }
            } while (choice != "1" && choice != "2" && choice != "3");
        }
    }
}
