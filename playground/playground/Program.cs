﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground
{
    
    class Program
    {

        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int am = 0;
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "generate-array":
                    Console.WriteLine(myArray);
                    break;

                case "get-array-statistics":
                    foreach(int x in myArray)
                    {
                        am = myArray.Sum() / myArray.Length;
                    }
                    Console.WriteLine("Максимальное число: "+myArray.Max());
                    Console.WriteLine("Минимальное число: "+myArray.Min());
                    Console.WriteLine("Среднее арифметическое равно: "+am);
                    break;
                   
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
    }
}
