using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);
            // Object[] objects = new Object[4]{lunokhod, apollo, sojourner, sputnik};
            // DirectAll(objects);
            IDirectable[] probes = new IDirectable[4] { lunokhod, apollo, sojourner, sputnik };
            DirectAll(probes);
            Console.ReadLine();

        }

        // static void DirectAll(Object[] objects){
        //   foreach(Object item in objects){
        //     Console.WriteLine($"Tracking a {item.GetType()} ....");
        //   }
        // }
        static void DirectAll(IDirectable[] probes)
        {
            foreach (IDirectable item in probes)
            {
                Console.WriteLine(item.GetInfo());
                Console.WriteLine(item.Explore());
                Console.WriteLine(item.Collect());
            }
        }
    }
    /*
     * 10.
Well done! If you’d like to keep practicing, try these extensions:

In Task 6, we decided to create a shared interface over a shared superclass. To prove that making a shared superclass really is more work, try it yourself: Remove the interface and create a shared Probe superclass. Instead of an array of type IDirectable[], make an array of type Probe[].
Try to answer this question on your own: in task 3, you called the Explore() and Collect() methods on each rover. Even though you used Rover references, the specific rover type (MoonRover or MarsRover) was printed. How is that possible?
     */
}
