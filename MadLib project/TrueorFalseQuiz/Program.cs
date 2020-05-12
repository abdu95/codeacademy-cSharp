using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueorFalseQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            /* version 1*/
            /**/
            //string[] questions = { "Moscow is in US", "Tokyo is in Japan", "Cloud is black" };
            //bool[] answers = { false, true, false };
            //bool[] responses = new bool[questions.Length];
            //if (questions.Length != answers.Length)
            //    Console.WriteLine("WARNING: Not equal length");
            //int askingIndex = 0;
            //foreach (string item in questions)
            //{
            //    string input;
            //    bool isBool;
            //    bool inputBool;

            //    Console.WriteLine(item);
            //    Console.WriteLine("True or false?");
            //    input = Console.ReadLine();

            //    isBool = Boolean.TryParse(input, out inputBool);
            //    while (!isBool)
            //    {
            //        Console.WriteLine("Please respond with 'true' or 'false'");
            //        input = Console.ReadLine();
            //        isBool = Boolean.TryParse(input, out inputBool);
            //    }
            //    responses[askingIndex] = inputBool;
            //    askingIndex++;
            //}

            //int scoringIndex = 0;
            //int score = 0;
            //foreach (bool answer in answers)
            //{
            //    bool response = responses[scoringIndex];
            //    Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");
            //    if (response == answer)
            //        score++;
            //    scoringIndex++;
            //}
            //Console.WriteLine($"You got {score} out of {questions.Length} correct");

            string[] questions = { "Moscow is in US", "Tokyo is in Japan", "Cloud is black" };
            bool[] answers = { false, true, false };
            RunQuiz(questions, answers);
            Console.ReadLine();
        }

        public static void RunQuiz(string[] questions, bool[]answers)
        {
            bool[] responses = new bool[questions.Length];
            if (questions.Length != answers.Length)
                Console.WriteLine("WARNING: Not equal length");
            int askingIndex = 0;
            foreach (string item in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(item);
                Console.WriteLine("True or false?");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            // string result = String.Join("", responses);
            // Console.WriteLine(result);

            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");
                if (response == answer)
                    score++;
                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of {questions.Length} correct");
        }
        //double[] temps = {89.5, 96.3, 100.0};
        //double[] temps;
        //temps = new double[] {89.5, 96.3, 100.0};

    }
}
