using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTheException
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            string dog = "chihuahua";
            string tinyDog = dog;
            dog = "dalmation";
            Console.WriteLine(dog);
            // Output: "dalmation"
            Console.WriteLine(tinyDog);
            // Output: "chihuahua"

            // Example 2
            string s1 = "Hello ";
            string s2 = s1;
            s1 += "World";
            System.Console.WriteLine(s1);
            // Output: "Hello World"
            System.Console.WriteLine(s2);
            // Output: "Hello"
        }
        /*
         * STRING, THE EXCEPTION
Review
Well done, you’re a reference master now!

The concept of references, especially the nuances of the string type, can be difficult to understand when they aren’t clearly visible in the code. Let the information sink in and play with some code to check your understanding. Once you get it, this concept will save you dozens of hours of debugging.

Here’s what was covered in this lesson:

The String or string type is a reference type
Strings are immutable, which means they cannot be changed after they are created
Being immutable also means that a string reference will always point to the original object, so “modifying” one reference to a string will not affect other references to it
With the equality operator (==), strings are checked for value, not referential, equality
A string variable can be unassigned, null, or empty. Empty strings can be represented by String.Empty or "" — they’re equivalent
         */
    }
}
