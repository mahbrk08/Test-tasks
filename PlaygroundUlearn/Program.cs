using System;

namespace PlaygroundUlearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }

        public static double Calculate()
        {
            double sum = Double.Parse(Console.ReadLine().Split(' '));
            double interestRate = Double.Parse(Console.ReadLine().Split(' '));
            double duration = Double.Parse(Console.ReadLine());
            double capitalazation = sum / 100 * interestRate * duration / 12;
            Console.WriteLine(sum + capitalazation);
            return sum + capitalazation;
        }

    }
}
