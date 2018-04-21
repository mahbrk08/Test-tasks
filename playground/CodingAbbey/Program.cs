using System;

namespace CodingAbbey
{
    class Program
    {
        static void Main()
        {
            var arguments = Console.ReadLine().Split(' ');
            var a = int.Parse(arguments[0]);
            var b = int.Parse(arguments[1]);
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}