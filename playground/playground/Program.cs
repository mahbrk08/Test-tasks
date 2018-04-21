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
using Microsoft.Win32.SafeHandles;

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

        public static void Swap(int index1, int index2, List<int> arr)
        {
            var temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
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

                var count = 0;

                for (int j = 0; j < list.Count - 1; j++)
                {
                    var notSwaped = true;
                    var min = j;
                    for (int i = j; i < list.Count - j -1; i++)
                    {
                        count++;
                        if (list[i] > list[i+1])
                        {
                            Swap(i, i+1, list);
                            notSwaped = false;
                        }

                        if (list[i] < list[min])
                        {
                            min = i;
                        }
    
                    }
                    if (notSwaped)
                    {
                        break;
                    }   
                    
                    if (min!=j)
                    {
                        Swap(j, min, list);
                    }
                    
                }
                    Console.WriteLine("Количество сравнений "+count);
                    Console.WriteLine("Cортировка:");
                    for (int x = 0; x < list.Count; x++)
                    {
                        Console.WriteLine(list[x]);
                        
                    }

                Console.ReadLine();
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

                case "read":
                    ReadFile();
                    break;

                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }

        public static void ReadFile()
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
                for (int x = 0; x < list.Count; x++)
                {
                    Console.WriteLine(list[x]);
                }
            }
        }
    }
}
