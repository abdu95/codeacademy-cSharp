using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
      This program: MadLib
      Author: Abdu
      */


            // Let the user know that the program is starting:
            Console.WriteLine("MadLab started!");

            // Give the Mad Lib a title:
            string title = "Crazy Story";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Give a name to the character: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter one adjective: ");
            string adjectiveOne = Console.ReadLine();
            Console.WriteLine("Enter one more adjective: ");
            string adjectiveTwo = Console.ReadLine();
            Console.WriteLine("Enter third adjective: ");
            string adjectiveThree = Console.ReadLine();
            Console.WriteLine("Enter a verb: ");
            string verb = Console.ReadLine();
            Console.WriteLine("Enter one noun: ");
            string firstNoun = Console.ReadLine();
            Console.WriteLine("Enter one more noun: ");
            string secondNoun = Console.ReadLine();
            Console.WriteLine("Name any animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine("Name any food: ");
            string food = Console.ReadLine();
            Console.WriteLine("Name any fruit: ");
            string fruit = Console.ReadLine();
            Console.WriteLine("Name any superhero: ");
            string superhero = Console.ReadLine();
            Console.WriteLine("Name any country: ");
            string country = Console.ReadLine();
            Console.WriteLine("Name any dessert: ");
            string dessert = Console.ReadLine();
            Console.WriteLine("Name any year: ");
            string year = Console.ReadLine();
            // The template for the story:

            string story = $@"This morning {name} woke up feeling {adjectiveOne}.
'It is going to be a {adjectiveTwo} day!' 
Outside, a bunch of {animal}s were protesting to keep {food} in stores. 
They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {adjectiveThree}. 
Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. 
{name} woke up in the year {year}, in a world where {secondNoun} ruled the world.";


            // Print the story:
            Console.WriteLine(story);
            Console.ReadLine();

        }
    }
}
