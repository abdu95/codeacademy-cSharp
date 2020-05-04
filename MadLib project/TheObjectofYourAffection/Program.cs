using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectofYourAffection
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "NY", "USA", "he/him");
            // sam.name = "Sam Drakkila";
            string[] hobbies = new string[] { "listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns" };
            sam.SetHobbies(hobbies);
            Console.WriteLine(sam.ViewProfile());
        }
    }
}
