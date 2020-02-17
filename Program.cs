using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHunger = 100;
            int startFullness = 0;
            int startTiredness = 20;
            int startHappiness = 0;
            int finalTired = 0;
            int finalHungry = 0;
            int finalHappy = 0;

            VirtualPet userPet = new VirtualPet();
            userPet.Hungriness = startHunger;
            userPet.Fullness = startFullness;
            userPet.Tiredness = startTiredness;
            userPet.Happiness = startHappiness;

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("HELLO !!!!!");
            Console.WriteLine("\n\nWelcome to VirtualPet application World!");
            Console.WriteLine("\n\nA Tamagotchi is a small, handheld digital pet that you can feed, play with,\n" +
                                    "put to bed and clean up after. Look after it well by feeding it the right kinds\n" +
                                    "of foods, showering it with attention and cleaning up after it when required,\n" +
                                    "and your Tamagotchi will grow up to be a smart,well-respected member of society.");

            Console.WriteLine("\n\n\n\n\n\nBefore entering the game please read the instructions below");
            Console.WriteLine("\nInstructions:\nIn this game you interact with your pet by playing , feeding, petting and\n" +
                "make your pet happy and reach to a maximum satisfaction level of 90 percentage.\n");
            Console.WriteLine("\t\t\t\t\t\tPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Please tell me your name? ");
            while (true)
            {
                string ownersName = Console.ReadLine();
                userPet.OwnersName = ownersName;
                if (!string.IsNullOrWhiteSpace(ownersName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid Name.");
                }

            }

            Console.WriteLine("\nHello {0}, here is your Tamagotchi the VirtualPet. Isn't looking adorable!", userPet.OwnersName);
            userPet.Image = userPet.TamagotchiImage;
            Console.WriteLine(userPet.Image);

            while (true)
            {
                Console.WriteLine("\nWhat would you like to name it instead of Tamagotchi?");
                String petsName = Console.ReadLine();
                userPet.PetsName = petsName;

                if (!string.IsNullOrWhiteSpace(petsName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Name.");
                }

            }
            Console.WriteLine("\n\n\nCongratulations {0}!\nYou are the proud new owner of {1} the virtual pet!", userPet.OwnersName, userPet.PetsName);
            Console.WriteLine("Your {0} says: Please take care of me :-)", userPet.PetsName);
            Console.WriteLine("\n\n\n\n\t\t\t\t\t\tPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //This  section of code "plays the game" until the pet's overall satisfaction reaches a certain point (here, 90). Then the game ends.

            do
            {
                userPet.ShowPetStatus();

                //user menu
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\tPress 1 to feed {0}.", userPet.PetsName);
                Console.WriteLine("\tPress 2 to make {0} to go to bed.", userPet.PetsName);
                Console.WriteLine("\tPress 3 to take {0} outside to go potty.", userPet.PetsName);
                Console.WriteLine("\tPress 4 to make {0} to spend time all alone.", userPet.PetsName);
                Console.WriteLine("\tPress 5 to play with {0}.", userPet.PetsName);
                Console.WriteLine("\tPress 6 to quit the game.");

                int userMethodChoice;
                do
                {
                    bool result = int.TryParse(Console.ReadLine(), out userMethodChoice);

                    if (result)
                    {
                        while (userMethodChoice < 1 || userMethodChoice > 6)
                        {
                            Console.WriteLine("You must choose an option from the menu!\nWhat would you like to do?");
                            userMethodChoice = int.Parse(Console.ReadLine());
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                } while (userMethodChoice >= 1 || userMethodChoice <= 6);

                Console.Clear();

                switch (userMethodChoice)
                {

                    case 1:
                        {

                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("\tPress 1 to feed {0} Choclates.", userPet.PetsName);
                            Console.WriteLine("\tPress 2 to feed {0} Biscuits.", userPet.PetsName);
                            Console.WriteLine("\tPress 3 to feed {0} sweets.", userPet.PetsName);
                            Console.WriteLine("\tPress 4 to feed {0} fruits.", userPet.PetsName);
                            Console.WriteLine("\tPress 5 to go back to main menu.");
                            finalHungry = userPet.Hungriness;
                            int userMethodChoice1;
                            do
                            {
                                bool result = int.TryParse(Console.ReadLine(), out userMethodChoice1);
                                if (result)
                                {
                                    while (userMethodChoice1 < 1 || userMethodChoice1 > 5)
                                    {
                                        Console.WriteLine("You must choose an option from the menu!\nWhat would you like to do?");
                                        userMethodChoice = int.Parse(Console.ReadLine());
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid number");
                                }
                            } while (userMethodChoice1 >= 1 || userMethodChoice1 <= 6);

                            Console.Clear();
                            switch (userMethodChoice1)
                            {

                                case 1:
                                    {
                                        userPet.FeedChoci();
                                        finalHungry = userPet.Hungriness;
                                    }
                                    break;

                                case 2:
                                    {
                                        userPet.FeedBiscuits();
                                        finalHungry = userPet.Hungriness;
                                    }
                                    break;

                                case 3:
                                    {
                                        userPet.FeedSweets();
                                        finalHungry = userPet.Hungriness;
                                    }
                                    break;

                                case 4:
                                    {
                                        userPet.FeedFruits();
                                        finalHungry = userPet.Hungriness;
                                    }
                                    break;

                                case 5:
                                    {
                                        if (finalHungry > 10)
                                        {
                                            Console.WriteLine("But, I'm still hungry");
                                        }
                                        else if (finalHungry <= 10)
                                        {
                                            Console.WriteLine("Thank you for the delicious food");
                                        }
                                    }
                                    break;
                            }
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("How much time you want {0} to sleep?", userPet.PetsName);
                            Console.WriteLine("\tPress 1 for 5 mins of sleep");
                            Console.WriteLine("\tPress 2 for 10 mins of sleep");
                            Console.WriteLine("\tPress 3 for 15 mins of sleep");
                            Console.WriteLine("\tPress 4 for 20 mins of sleep");
                            Console.WriteLine("\tPress 5 to go back to main menu.");
                            finalTired = userPet.Tiredness;

                            int userMethodChoice2;
                            do
                            {
                                bool result = int.TryParse(Console.ReadLine(), out userMethodChoice2);
                                if (result)
                                {
                                    while (userMethodChoice2 < 1 || userMethodChoice2 > 6)
                                    {
                                        Console.WriteLine("You must choose an option from the menu!\nWhat would you like to do?");
                                        userMethodChoice2 = int.Parse(Console.ReadLine());
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid number");
                                }
                            } while (userMethodChoice2 >= 1 || userMethodChoice2 <= 6);

                            Console.Clear();
                            switch (userMethodChoice2)
                            {

                                case 1:
                                    {
                                        userPet.SleepFive();
                                        finalTired = userPet.Tiredness;
                                        if (finalTired > 10)
                                        {
                                            Console.WriteLine("but I'm still tired need to sleep for some more time");
                                        }
                                        else if (finalTired <= 10)
                                        {
                                            Console.WriteLine("I had a good sleep, thank you");
                                        }
                                    }
                                    break;

                                case 2:
                                    {
                                        userPet.SleepTen();
                                        finalTired = userPet.Tiredness;
                                        if (finalTired > 10)
                                        {
                                            Console.WriteLine("but I'm still tired need to sleep for some more time");
                                        }
                                        else if (finalTired <= 10)
                                        {
                                            Console.WriteLine("I had a good sleep, thank you");
                                        }
                                    }
                                    break;

                                case 3:
                                    {
                                        userPet.SleepFifteen();
                                        finalTired = userPet.Tiredness;
                                        if (finalTired > 10)
                                        {
                                            Console.WriteLine("but I'm still tired need to sleep for some more time");
                                        }
                                        else if (finalTired <= 10)
                                        {
                                            Console.WriteLine("I had a good sleep, thank you");
                                        }
                                    }
                                    break;

                                case 4:
                                    {
                                        userPet.SleepTwenty();
                                        finalTired = userPet.Tiredness;
                                        if (finalTired > 10)
                                        {
                                            Console.WriteLine("but I'm still tired need to sleep for some more time");
                                        }
                                        else if (finalTired <= 10)
                                        {
                                            Console.WriteLine("I had a good sleep, thank you");
                                        }

                                    }
                                    break;

                                case 5:
                                    {
                                        if (finalTired > 10)
                                        {
                                            Console.WriteLine("{0} says, \"Im tired, allow me to sleep for some more time\"", userPet.PetsName);
                                        }
                                        else if (finalTired <= 10)
                                        {
                                            Console.WriteLine("I had a good sleep, thank you");
                                        }
                                    }
                                    break;
                            }
                        }
                        break;

                    case 3:
                        {
                            userPet.Bathroom();
                        }
                        break;

                    case 4:
                        {
                            userPet.SpendTimeAlone();
                        }
                        break;

                    case 5:
                        {
                            Console.WriteLine("What do you want to play with {0}?", userPet.PetsName);
                            Console.WriteLine("\tPress 1 to make {0} play with Ball.", userPet.PetsName);
                            Console.WriteLine("\tPress 2 to make {0} Jump over rope.", userPet.PetsName);
                            Console.WriteLine("\tPress 3 to make {0} run along with {1}.", userPet.PetsName, userPet.OwnersName);
                            Console.WriteLine("\tPress 4 to go back to main menu.");
                            finalTired = userPet.Tiredness;
                            finalHappy = userPet.Happiness;
                            int userMethodChoice3;
                            do
                            {
                                bool result = int.TryParse(Console.ReadLine(), out userMethodChoice3);
                                if (result)
                                {
                                    while (userMethodChoice3 < 1 || userMethodChoice3 > 5)
                                    {
                                        Console.WriteLine("You must choose an option from the menu!\nWhat would you like to do?");
                                        userMethodChoice3 = int.Parse(Console.ReadLine());
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid number");
                                }
                            } while (userMethodChoice >= 1 || userMethodChoice <= 5);
                            Console.Clear();
                            switch (userMethodChoice3)
                            {

                                case 1:
                                    {
                                        userPet.PlayBall();
                                        finalTired = userPet.Tiredness;
                                        finalHappy = userPet.Happiness;
                                    }
                                    break;

                                case 2:
                                    {
                                        userPet.PlayRope();
                                        finalTired = userPet.Tiredness;
                                        finalHappy = userPet.Happiness;

                                    }
                                    break;

                                case 3:
                                    {
                                        userPet.PlayRun();
                                        finalTired = userPet.Tiredness;
                                        finalHappy = userPet.Happiness;
                                    }
                                    break;

                                case 4:
                                    {
                                        if (finalTired > 10 || finalHappy > 10)
                                        {
                                            Console.WriteLine("I'm having fun with you, dont leave me");
                                        }
                                        else if (finalTired <= 10 || finalHappy <= 10)
                                        {
                                            Console.WriteLine("Bye Bye!!!");
                                        }

                                    }
                                    break;
                            }
                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine("{0} says, \"You're leaving me?\"", userPet.PetsName);
                            Console.WriteLine("I will be waiting for your return!!! ");
                            Console.WriteLine("\n\n\n\n\nBelow is the status of your pet");
                            userPet.ShowPetStatus();
                            Console.WriteLine("\t\t\t\t\t\tPress any key to exit");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("{0)} says, \"Thanks for the extra food!\"", userPet.PetsName);
                            userPet.FeedChoci();
                            break;
                        }

                }
                Console.WriteLine("\t\t\t\t\t\tPress any key to continue");
                Console.ReadKey();
                Console.Clear();

            } while (userPet.PetSatisfaction <= 90);

            //this section of code is what appears when the user has won the game (when satisfaction is greater than 90).

            Console.WriteLine(userPet.Image);
            Console.WriteLine("\nCongratulations {0}!\nYou have successfully satisfied your pet {1} for today", userPet.OwnersName, userPet.PetsName);
            Console.WriteLine("\n\n\n\nBelow is the status");
            userPet.ShowPetStatus();
            Console.WriteLine("\n\n\n\n\n\n\t\t\tPress any key to continue to come out of the game");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }

}
