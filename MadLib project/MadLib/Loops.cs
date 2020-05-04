using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Loops
    {
        static void Main(string[] args)
        {
            int emails = 20;
            while (emails > 0)
            {
                emails = emails - 1;
                Console.WriteLine($"Deleting an email. {emails} emails left");
            }
            Console.WriteLine("INBOX ZERO ACHIEVED!");
            //double[] numbers = double[]{ 8.6, 9.5};
            //strange quiz question

        }
    }
}
