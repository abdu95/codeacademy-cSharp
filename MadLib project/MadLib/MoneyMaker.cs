using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class MoneyMaker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter the amount of money to convert to coins: ");
            string input = Console.ReadLine();
            double amount = Math.Floor(Convert.ToDouble(input));
            Console.WriteLine($"{amount} cents is equal to..");
            double goldCoin = 10;
            double silverCoin = 5;
            double goldCoins = Math.Floor(amount / goldCoin);
            double remainder = amount % goldCoin;
            double silverCoins = Math.Floor(remainder / silverCoin);
            remainder = remainder % silverCoin;
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");
            Console.ReadLine();
        }
    }
}
