using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class PasswordChecker
    {
        static void Main(string[] args)
        {
            //Use RegEx instead of Tool.Contains 
            //https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=netframework-4.8#examples

            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()-=+_";
            Console.WriteLine("Enter a password");
            string input = Console.ReadLine();
            int score = 0;
            if (input.Length >= minLength)
            {
                score++;
            }
            //if (Tools.Contains(input, uppercase))
            //{
            //    score++;
            //}
            //if (Tools.Contains(input, lowercase))
            //{
            //    score++;
            //}
            //if (Tools.Contains(input, digits))
            //{
            //    score++;
            //}
            //if (Tools.Contains(input, specialChars))
            //{
            //    score++;
            //}
            Console.WriteLine(score);
            string result = "";
            switch (score)
            {
                case 4:
                case 5:
                    result = "Extremely strong";
                    break;
                case 3:
                    result = "Strong";
                    break;
                case 2:
                    result = "Medium";
                    break;
                case 1:
                    result = "Weak";
                    break;
                default:
                    result = "Password doesn't meet any of the standards";
                    break;

            };
            Console.WriteLine(result);
        }
    }
}
