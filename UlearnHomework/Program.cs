﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UlearnHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while(true)
            AdvancedClockAngle();
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

        public static int LeapYear(int start, int end) //5 задача
        {
            return GetYearsDividedBy(start, end, 4) - 
                   GetYearsDividedBy(start, end, 100) +
                   GetYearsDividedBy(start, end, 400);
        }

        private static int GetYearsDividedBy(int start, int end, int divider) //5 задача
        {
            var result = 0;
            var yearsToLeap = start % divider;
            if (start % divider == 0)
            {
                result = (end - start) / divider + 1;
            }
            else
            {
                result = (end - start + yearsToLeap) / divider;
            }

            return result;
        }

        public static double GetDistance() //6 задача
        {
            var vector = ReadVector();
            var point0 = GetPoint("Ведите координаты точки, до которой нужно найти расстояние");
            return Math.Abs(vector.a*point0.x + vector.b*point0.y + vector.c)/Math.Sqrt(vector.a*vector.a + vector.b*vector.b);
        }

        private static (double x, double y) GetPoint(string message)
        {
            Console.WriteLine(message);
            var x = Double.Parse(Console.ReadLine());
            var y = Double.Parse(Console.ReadLine());
            
            return (x, y);
        }

        /// <summary>
        /// Просит ввести две точки на прямой
        /// </summary>
        /// <returns>Вохвращает коэффициенты в уравнении прямой</returns>
        private static (double a, double b, double c) ReadVector()
        {
            var point1 = GetPoint("Ведите координаты первой точки на прямой");
            var point2 = GetPoint("Ведите координаты второй точки на прямой");
            var varA = point1.y - point2.y;
            var varB = point2.x - point1.x;
            var varC = point1.x * point2.y - point2.x * point1.y;
            return (varA, varB, varC);
        }

        public static void ParallelsLines()
        {
            var vector = ReadVector();
            Console.WriteLine($"Параллельная прямая: {vector.a}x + {vector.b}y + c1 = 0, где c1 != {vector.c}");

        }

        public static void Perpendicular()
        {
            var vector = ReadVector();
            Console.WriteLine($"Перпенликулярная прямая: {vector.b}x - {vector.a}y + c2 = 0");
        }

        public static void Sum() //10 задача (Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.)
        {
            int n = 0;
                for(n = 0; n<1000; n++)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                    n = n + n;
                    Console.WriteLine(n);
                    n++;
                }
                
            }
                           
        }

        public static void AdvancedClockAngle() //11 задача(Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.)
        {
            var hours = Int32.Parse(Console.ReadLine());
            var minutes = Int32.Parse(Console.ReadLine());
            var oneHourAngle = 30;
            var oneMinuteAngle = 6;
            var angle = 0; /*hours * 30 + minutes / 60 * 30*/
            if (hours * oneHourAngle >= minutes * oneMinuteAngle)
            {
                angle = hours * oneHourAngle - minutes * oneMinuteAngle;
            }
            else
            {
                angle = minutes * oneMinuteAngle - hours * oneHourAngle;
            }

            Console.WriteLine(angle);
        }

        public static void PassangerComfort() //12 Задача
        {
            var height = Int32.Parse(Console.ReadLine());
            var time = Int32.Parse(Console.ReadLine());
            var speedPerSecond = Int32.Parse(Console.ReadLine());
            var x = 0;
        }

        public static double GoatFeast(double length, double rope)
        {
            var fieldSquare = length * length;
            var ropeSquare = rope * rope * Math.PI;
            var eatenSquare = 0.0;
            if (length < 2 * rope)
            {
                double angle = Math.Acos(length / 2 / rope);
                eatenSquare -= 4 * (angle * rope * rope - length / 2 * rope * Math.Sin(angle));
            }
            return eatenSquare;
        }
    }

}
