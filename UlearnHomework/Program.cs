using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockAngle();
            Console.ReadKey();
        }

        public static void Swap(int a, int b)// 1 задача
        {

            var temp = a;
            a = b;
            b = temp;
        }

        public static string Switch(string num)//2 задача
        {

            num = num.Replace(num[0], num[2]);
            Console.WriteLine(num);
            return num;
            
        }

        public static void ClockAngle()//3 задача(дописать)
        {
            //Перед выходом пришла в голову мысль что возможно получится написать код через 2 массива Hours(pm,am)
            //Которые хранили бы в своих элементах углы.
            var time = 0;
            var angle = 0;
            var dayTime = Console.ReadLine().Split(' ');
            var commandName = dayTime[0];


            switch (commandName)
            {
                case "am":
                    for (time = Int32.Parse(Console.ReadLine()); time <= 12; time++)
                    {
                        angle = 30 * time;
                        Console.WriteLine(time + " " + angle);
                    }
                    break;

                case "pm":
                    for (time = Int32.Parse(Console.ReadLine()); time <= 12; time++)
                    {
                        if (time == 12)
                        {
                            angle = 0;
                        }
                        angle = 360 - 30*time;
                        Console.WriteLine(time + " " + angle);
                    }
                    break;

            }

        }

        public static int Divider(int num)//4 задача(дописать)
        {

            int divider = 0;
            for (var i = 1; i < num; i++)
                if (num % i == 0)
                    divider++;
            Console.WriteLine(divider);

            return divider;
        }

        public static int LeapYear(int a, int b)//5 задача(дописать)
        {
            var start = a;
            var end = b;
            var interval = b - a;
            var leap = 0;
            for (int x = 1; x <= interval; x++)
            {
                if (x % 4 == 0)
                leap++;
                Console.WriteLine(leap);
            }
            
            return leap;

        }
    }
}
