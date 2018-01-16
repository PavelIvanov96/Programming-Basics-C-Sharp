using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (season == "winter")
            {
                if (budget <= 100)
                {
                    Console.WriteLine("Economy class");
                    Console.WriteLine("Jeep - {0:f2}", budget * 0.65);
                }
                else if (budget <= 500)
                {
                    Console.WriteLine("Compact class");
                    Console.WriteLine("Jeep - {0:f2}", budget * 0.80);
                }
                else if (budget >= 500)
                {
                    Console.WriteLine("Luxury class");
                    Console.WriteLine("Jeep - {0:f2}", budget * 0.90);
                }
            }
            else if (season == "summer")
            {
                if (budget <= 100)
                {
                    Console.WriteLine("Economy class");
                    Console.WriteLine("Cabrio - {0:f2}", budget * 0.35);
                }
                else if (budget <= 500)
                {
                    Console.WriteLine("Compact class");
                    Console.WriteLine("Cabrio - {0:f2}", budget * 0.45);
                }
                else if (budget >= 500)
                {
                    Console.WriteLine("Luxury class");
                    Console.WriteLine("Jeep - {0:f2}", budget * 0.90);
                }
            }
        }
    }
}
