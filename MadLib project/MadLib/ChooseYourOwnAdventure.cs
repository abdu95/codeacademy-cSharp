using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class ChooseYourOwnAdventure
    {
            static void Main(string[] args)
            {
                /* THE MYSTERIOUS NOISE */

                // Start by asking for the user's name:
                Console.Write("What is your name?: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello, {name}! Welcome to our story.");
                Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
                Console.Write("Type YES or NO: ");
                string noiseChoice = Console.ReadLine().ToUpper();
                // noiseChoice = noiseChoice.ToUpper();
                if (noiseChoice == "NO")
                {
                    Console.WriteLine("Not much of an adventure if we don't leave our room!");
                    Console.WriteLine("THE END.");
                }
                else if (noiseChoice == "YES")
                {
                    Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
                }
                Console.Write("Type OPEN or KNOCK: ");
                string doorChoice = Console.ReadLine().ToUpper();
                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \n \"Answer this riddle: \" \n \"Poor people have it. Rich people need it. If you eat it you die. What is it?\" ");
                    Console.Write("Type your answer: ");
                    string riddleAnswer = Console.ReadLine().ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there. ");
                        Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                        Console.WriteLine("THE END.");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.");
                        Console.WriteLine("THE END.");
                    }

                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number (1-3): ");
                    string keyChoice = Console.ReadLine();
                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!");
                            Console.WriteLine("The door opens and NOTHING is there.");
                            Console.WriteLine("Strange....");
                            Console.WriteLine("THE END");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.");
                            Console.WriteLine("THE END.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.");
                            Console.WriteLine("THE END.");
                            break;
                        default:
                            Console.WriteLine("THE END");
                            break;
                    }
                }
            }
        }
        /*
        Try different options. When you hit the end of the program, re-run it and make a different decision than you did before. Keep doing that until you’ve gone through all the possible endings to make sure your program looks correct, no matter what options your user chooses.

      If you are feeling ambitious, here are some extensions:

      Modify the story and the code to create your very own Choose Your Adventure
      Include more cases to check for other user input (what if a user picks a choice you didn’t include?)
      Use ternary operators
        */
    
}
