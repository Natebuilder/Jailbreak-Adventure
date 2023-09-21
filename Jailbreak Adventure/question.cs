﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jailbreak_Adventure
{
    public class question
    {
        public static void question1()
        {
            string choice;
            Console.WriteLine($"Score: {Program.Score}\n");
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
                case "1":
                case "Punch him in face":
                case "Punch face":
                    {
                        Program.Score += 100;
                        Console.WriteLine($"Score: {Program.Score}\n");
                        Console.WriteLine("You punched the cop in the face.");
                        Console.WriteLine("As result the cop is knockout and you stole his keycard.");
                        Console.WriteLine("Press enter to continue!");
                        Console.ReadLine();
                        Console.Clear();
                        question2();
                        break;
                    }
                case "2":
                case "Act like a scary witch":
                case "Scary Witch":
                    {
                        Program.Score -= 100;
                        Console.WriteLine($"Score: {Program.Score}\n");
                        Console.WriteLine("You act like a scary witch in front of a cop.");
                        Console.WriteLine("Too bad your acting is bad and the cop knock you out.");
                        Console.WriteLine("Meanwhile an another prison got hungry and he ate you!!");
                        Console.WriteLine("Press enter to continue!");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver.gameOver2();
                        break;
                    }
                case "3":
                case "Vomit in face":
                case "Vomit face":
                    {
                        Program.Score -= 100;
                        Console.WriteLine($"Score: {Program.Score}\n");
                        Console.WriteLine("You vomit in the cop's face. He got angry and shoot in your head.");
                        Console.WriteLine("As result you are dead.");
                        Console.WriteLine("Press enter to continue!");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver.gameOver1();
                        break;
                    }
            }
        }
        public static void question2()
        {
            string choice;
            Console.WriteLine($"Score: {Program.Score}\n");
            Console.WriteLine("You stole the keycard. 2 cops are watching the door by the police station.");
            Console.WriteLine("What are you gonna do?.");
            Console.WriteLine("1. Run to the door.");
            Console.WriteLine("2. Sneak on the cops and knock them out.");
            Console.WriteLine("3. Try to find an another cop.");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

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
                        gameOver.gameOver3();
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
                        gameOver.gameOver4();
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
                        question3();
                        break;
                    }
            }

        }
        public static void question3()
        {
            string choice;
            Console.WriteLine($"Score: {Program.Score}\n");
            Console.WriteLine("You found a sleeping cop. No other cops knows that.");
            Console.WriteLine("What are you gonna do to that cop?");
            Console.WriteLine("1. Steal his clothes and go undercover.");
            Console.WriteLine("2. Kill the cop and threat the other cops..");
            Console.WriteLine("3. Steal his gun");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

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
                        gameOver.gameOver5();
                        break;
                    }
                case "2":
                case "Kill the cop":
                case "Kill cop":
                    {
                        Program.Score -= 100;
                        Console.WriteLine($"Score: {Program.Score}\n");
                        Console.WriteLine("You punched the cop's head off.");
                        Console.WriteLine("You walk to the other cops With a disgusting head ");
                        Console.WriteLine("You threat like if you don't let me you this will happen to you.");
                        Console.WriteLine("The other cops aren't scared and that shoot you to death");
                        Console.WriteLine("Press enter to continue!");
                        Console.ReadLine();
                        Console.Clear();
                        gameOver.gameOver6();
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
                        Console.WriteLine("You shoot the 2 cops down and you use your keycard");
                        Console.WriteLine("to go in the police station.");
                        Console.WriteLine("Press enter to continue!");
                        Console.ReadLine();
                        Console.Clear();
                        question4();
                        break;
                    }
            }
        }
    }
}
