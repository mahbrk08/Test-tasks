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
                    FileStream file1 = new FileStream(@"C:\\Users\\i7\\source\repos\\playground\arrays.csv", FileMode.Open, FileAccess.ReadWrite);
                    StreamWriter writer = new StreamWriter(file1);
                       for (int index = 0; index < myArray.Length; index++)
                        {
                            myArray[index] = random.Next();
                            writer.WriteLine(myArray[index]);
                            Console.WriteLine(myArray[index]);
                        }
                    writer.Close();
                    break;

                case "get-array-statistics":
                    FileStream file2 = new FileStream(@"C:\\Users\\i7\\source\repos\\playground\arrays.csv", FileMode.Open, FileAccess.ReadWrite);
                    StreamReader reader = new StreamReader(file2);
                    //int myArray1 = Int32.Parse(reader.ReadToEnd()); Изначально пытался присвоить значение для myArray, но понял что там не int, а int[], ввёл другую переменную, но консоль всё равно ругается)
                    //Console.WriteLine(myArray1); Вывело ошибку
                    Console.WriteLine(reader.ReadToEnd());
                    reader.Close();
                    //am = myArray.Sum() / myArray.Length;
                        //Console.WriteLine("Максимальное число: "+myArray.Max());
                        //Console.WriteLine("Минимальное число: "+myArray.Min());
                        //Console.WriteLine("Среднее арифметическое равно: "+am);
                    

                   
                    break;
                   
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
    }
}
