using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class ArchitectArithmetic
    {
        public static void Main(string[] args)
        {
            CalculateTotalCost();
            Console.ReadLine();
        }
        //ArchitectArithmetic
        static double RectangleArea(double length, double width)
        {
            return length * width;
        }
        static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double TriangleArea(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

        static void CalculateTotalCost()
        {
            double rectangle;
            double circle;
            double triangle;
            double totalArea;
            double totalCost;
            Console.WriteLine("What monument would you like to work with? ");
            string monument = Console.ReadLine();
            monument = monument.ToUpper();
            if (monument == "TEOTIHUACAN")
            {
                rectangle = RectangleArea(2500, 1500);
                circle = CircleArea(375);
                triangle = TriangleArea(750, 500);
                totalArea = rectangle + circle + triangle;
                totalCost = Math.Round(totalArea * 180, 2);
                Console.WriteLine($"The plan for that monument costs {totalCost} pesos!");
            }
            // else if(monument == "TAJ MAHAL"){
            //   rectangle = RectangleArea(90.5, 90.5);
            //   triangle = TriangleArea(750, 500);
            //   totalArea = rectangle + circle + triangle;
            //   totalCost = Math.Round(totalArea * 180, 2);
            //   Console.WriteLine($"The plan for that monument costs {totalCost} pesos!");  
        }
    }

}
