using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace playground
{
    
    class Program
    {

        static void Main(string[] args)
        {

            int[] myArray = new int [10];
            Random random = new Random();
            int am = 0;
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "generate-array":
                   

                       for (int index = 0; index < myArray.Length; index++)
                        {
                            myArray[index] = random.Next();
                            Console.WriteLine(myArray[index]);
                            File.WriteAllText("C:\\Users\\i7\\source\\repos\\playground\\arrays.csv" + myArray[index]); //В этой строчке выдаёт ошибку, код - CS1501 "Ни одна из перезагрузок метода WriteAllText не принимает 1 аргументов"
                        }
                    
                    break;

                case "get-array-statistics":
                    foreach(int x in myArray)
                    {
                        int rnd = random.Next();
                        am = myArray.Sum() / myArray.Length;
                        Console.WriteLine("Максимальное число: "+myArray.Max());
                        Console.WriteLine("Минимальное число: "+myArray.Min());
                        Console.WriteLine("Среднее арифметическое равно: "+am);
                    }

                   
                    break;
                   
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
    }
}
