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
			while (true)
			{
				ClockAngle();
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

        public static void ClockAngle()//3 задача(дописать)
        {
			//Перед выходом пришла в голову мысль что возможно получится написать код через 2 массива Hours(pm,am)
			//Которые хранили бы в своих элементах углы.
			var time = Int32.Parse(Console.ReadLine());
			var angle = 0;
            var dayTime = Console.ReadLine().Split(' ');
            var commandName = dayTime[0];


            switch (commandName)
            {
                case "am":
					

                case "pm":
                    

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
