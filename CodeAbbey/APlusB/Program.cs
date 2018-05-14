using System;

namespace APlusB
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var array = Console.ReadLine().Split(' ');
                
                if (array.Length != 2)
                {
                    Console.WriteLine("Введите 2 значения.");
                }
                else if (!int.TryParse(array[0], out var a) ||
                        !int.TryParse(array[1], out var b))
                {
                    Console.WriteLine("Введите числа.");
                }
                else
                {
                    var sum = a + b;
                    Console.WriteLine(sum);
                    Console.ReadKey();
                    break;
                }
            }

        }
    }
}