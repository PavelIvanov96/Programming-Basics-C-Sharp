﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('*', n * 2) +
                    new string(' ', n) +
                    new string('*', n * 2));
            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2) + "*");


                if (i == (n - 1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2) + "*");

                Console.WriteLine();
            }
            Console.Write(new string('*', n * 2) +
                    new string(' ', n) +
                    new string('*', n * 2));
            Console.WriteLine();

        }
    }
}