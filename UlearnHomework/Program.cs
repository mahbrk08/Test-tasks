using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
			while (true)
			{
				var result = LeapYear(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
			    Console.WriteLine(result);
			}
        }

        public static void Swap(int a, int b)// 1 задача
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public static void Switch(int num)//2 задача
        {
			var firstDigit = num / 100;
			var secondDigit = (num % 100) / 10;
			var thirdDigit = (num % 10);

			var result = firstDigit + secondDigit * 10 + thirdDigit * 100;
			Console.WriteLine(result);
		}

        public static void ClockAngle()//3 задача 
        {
			var time = Int32.Parse(Console.ReadLine());
			var angle = 0;
            if (time>12)
            {
                time -= 12;
            }
            
            if (time>=6)
            {
                angle = 360 - 30 * time;
            }
            
            else
            {
                angle = 30 * time;
            }
            
            Console.WriteLine(time + " " + angle);

        }

        public static int Divider(int num, int x, int y)//4 задача
        {

            int divider = 0;
            for (var i = 1; i < num; i++)
                if (i % x == 0 || i % y  == 0)
                    divider++;
            Console.WriteLine(divider);

            return divider;
        }

        public static int LeapYear(int a, int b)//5 задача(дописать)
        {
            var start = a;
            var end = b;
            var leap = 0;
            if ((b-a)%4==0)
            {
                
                leap = (b - a) / 4 + 1;
            }
            else
            {
                leap = (b - a) / 4;
            }

            return leap;

        }
    }
}
