using System;

namespace PlaygroundUlearn
{
    class Program
    {
        static void Main(string[] args)
        {
                Calculate(Console.ReadLine());
        }

        public static double Calculate(string userInput)
        {
            string[] tokens = userInput.Split();
            double result;
            double sum = Double.Parse(tokens[0]);
            double interestRate = Double.Parse(tokens[1]);
            double duration = Double.Parse(tokens[2]);
            return result = sum * Math.Pow(1 + (interestRate / (100 * 12)), duration);
        }

    }
}
