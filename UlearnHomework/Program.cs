﻿using System;
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
            Divider(Int32.Parse(Console.ReadLine()));
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
                        Console.WriteLine(angle);
                    }
                    break;


            }

        }

        public static int Divider(int num)//4 задача(дописать)
        {

            int counter = 0;
            for (var i = 1; i < num; i++)
                if (num % i == 0)
                    counter++;
            Console.WriteLine(counter);

            return counter;
        }
    }
}