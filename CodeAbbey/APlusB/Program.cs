using System;

namespace APlusB
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var inputData = Console.ReadLine();
                if (inputData == "exit")
                {
                    break;
                }
                
                var array = inputData.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
                
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
                    Console.WriteLine("Введите еще 2 значения.");
                }
            }
        }
    }
}