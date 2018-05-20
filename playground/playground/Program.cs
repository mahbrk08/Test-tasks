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
            var list = new List<int>();
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var randomInt = random.Next(1, 100);
                list.Add(randomInt);
            }
            
            WriteFile(list);
        }

        public static void GetStatistics()
        {
            var list = ReadFile();

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
                var list = ReadFile();

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
                    
            
                WriteFile(list);
                WriteConsole(list);
                Console.ReadLine();
            



        }

        public static void Main(string[] args)
        {
            var arguments = Console.ReadLine().Split(' ');
            var commandName = arguments[0];
            switch (commandName)
            {
                case "search":
                    Console.WriteLine(Search(Int32.Parse(arguments[1])));
                    Console.ReadLine();
                    break;
                    
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
                
                case "swap-array":
                    SwapArray();
                    break;
                
                case "shuffle-array":
                    ShuffleArray();
                    break;

                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }

        public static List<int> ReadFile()
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

            return list;
        }

        public static void WriteFile(List<int> list)
        {
            using (var file = new FileStream(@"arrays.csv", FileMode.Create, FileAccess.ReadWrite))
            using (var writer = new StreamWriter(file))
            {
                foreach (var item in list)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public static void WriteConsole(List<int> list)
        {
            for (int x = 0; x < list.Count; x++)
            {
                Console.WriteLine(list[x]);       
            }
        }

        public static void SwapArray()
        {
            var list = ReadFile();
            for (int i = 0; i < list.Count - 1; i += 3)
            {
               Swap(i, i+2, list);    
            }
            WriteConsole(list);
            WriteFile(list);
            Console.ReadLine();
        }

        public static void ShuffleArray()
        {
            var list = ReadFile();
            var random = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                var rndm = random.Next(0, 9);
                Swap(i, rndm, list);
            }
            WriteConsole(list);
            WriteFile(list);
            Console.ReadLine();
        }

        public static int Search(int value)
        {
            var list = ReadFile();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return i;
                }
            }
            
            return -1;
        }
    }
}
