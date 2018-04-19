using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace playground
{

    public class Program
    {
        public static void GenerateArray()
        {
            using (var file = new FileStream(@"arrays.csv", FileMode.Create, FileAccess.ReadWrite))
            using (var writer = new StreamWriter(file))
            {
                var random = new Random();
                for (var index = 0; index < 10; index++)
                {
                    var randomInt = random.Next(1, 100);
                    writer.WriteLine(randomInt);
                }
            }
        }

        public static void GetStatistics()
        {
            var list = new List<int>();
            using (var file = new FileStream(@"arrays.csv", FileMode.Open, FileAccess.ReadWrite))
            using (var reader = new StreamReader(file))

            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    list.Add(Int32.Parse(line));
                    line = reader.ReadLine();
                }
            }

            var sum = 0;
            var min = Int32.MaxValue;
            var max = Int32.MinValue;
            foreach (var item in list)
            {
                sum += item;
                if (item < min)
                {
                    min = item;
                }

                if (item > max)
                {
                    max = item;
                }
            }


            var am = sum / list.Count;
            Console.WriteLine("СА " + am);
            Console.WriteLine("max " + max);
            Console.WriteLine("min " + min);
            Console.ReadLine();
        }

        public static void Swap(int a, int b)
        {
            var temp =a;
            a = b;
            b = temp;
        }

        public static void Sort()
        {
            var list = new List<int>();
            using (var file = new FileStream(@"arrays.csv", FileMode.Open, FileAccess.ReadWrite))
            using (var reader = new StreamReader(file))

            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    list.Add(Int32.Parse(line));
                    line = reader.ReadLine();
                }


                for (int j = 0; j < line.Length; j++)
                {
                    var min = j;

                    for (int i = j + 1; i < line.Length - j;)
                    {
                        if (line[j] > line[i])
                        {
                            Swap(line[j], line[i]);
                            
                        }

                        if (line[i] < line[min])
                        {
                            min = i;
                        }

                        break;
                    }

                }

            }



        }

        public static void Main(string[] args)
        {

            var commandName = Console.ReadLine();
            switch (commandName)
            {
                case "generate-array":
                    GenerateArray();
                    break;

                case "get-array-statistics":
                    GetStatistics();
                    break;

                case "sort-array":
                    Sort();
                    break;

                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
    }
}
