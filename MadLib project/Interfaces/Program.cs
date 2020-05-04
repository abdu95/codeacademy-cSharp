using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s1 = new Sedan(60);
            Sedan s2 = new Sedan(70);
            Truck t1 = new Truck(45, 500);
            Console.WriteLine($"Speed: {s1.Speed}, Wheels: {s1.Wheels}, LicensePlate: {s1.LicensePlate}");
            Console.WriteLine($"Speed: {s2.Speed}, Wheels: {s2.Wheels}, LicensePlate: {s2.LicensePlate}");
            Console.WriteLine($"Speed: {t1.Speed}, Wheels: {t1.Wheels}, LicensePlate: {t1.LicensePlate}");
            s1.SpeedUp();
            s2.SpeedUp();
            t1.SpeedUp();
            Console.WriteLine($"Speed: {s1.Speed}");
            Console.WriteLine($"Speed: {s2.Speed}");
            Console.WriteLine($"Speed: {t1.Speed}");

        }
    }
}
