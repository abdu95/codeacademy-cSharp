using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Playlist
    {

            static void Main(string[] args)
            {
                string[] summerStrut;

                summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

                int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
                int position = Array.IndexOf(ratings, 3);
                Console.WriteLine($"Song number {position + 1} is rated three stars");
                string firstSong = Array.Find(summerStrut, song => song.Length > 10);
                Console.WriteLine($"The first song that has more than 10 characters in the title is {firstSong}.");
                Array.Sort(summerStrut);
                Console.WriteLine($"First song is {summerStrut[0]} and the last song is {summerStrut[7]}");

            }

        static void Main2(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            string[] summerStrutCopy = new string[summerStrut.Length];
            Array.Copy(summerStrut, summerStrutCopy, 8);
            Console.WriteLine($"{summerStrutCopy[0]}");
            Array.Reverse(summerStrut);
            Console.WriteLine($"{summerStrut[0]} {summerStrut[7]}");

            Array.Clear(summerStrut, 0, summerStrut.Length);
            Console.WriteLine($"{summerStrut[0]}");


        }
    }
    }
