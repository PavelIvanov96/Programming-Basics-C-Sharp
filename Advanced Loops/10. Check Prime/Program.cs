﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 2)
            {
                Console.WriteLine("Not prime");
                return;
            }

            bool isPrime = true;


            for (int i = 2; i <= Math.Sqrt(num); i++)
            {

                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
