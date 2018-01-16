using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            var procent = 0.0;
            if (budget <= 1000)
            {

                if (season == "summer")
                {
                    procent = 0.65 * budget;
                    Console.WriteLine("Alaska - Camp - {0:f2}", procent);
                }
                else
                {
                    procent = 0.45 * budget;
                    Console.WriteLine("Morocco - Camp - {0:f2}", procent);

                }

            }
            if (budget > 1000 && budget <= 3000)
            {

                if (season == "summer")
                {
                    procent = 0.80 * budget;
                    Console.WriteLine("Alaska - Hut - {0:f2}", procent);
                }
                else
                {
                    procent = 0.60 * budget;
                    Console.WriteLine("Morocco - Hut - {0:f2}", procent);

                }
            }
            if (budget > 3000)
            {

                if (season == "summer")
                {
                    procent = 0.90 * (double)budget;
                    Console.WriteLine("Alaska - Hotel - {0:f2}", procent);
                }
                else
                {
                    procent = 0.90 * (double)budget;
                    Console.WriteLine("Morocco - Hotel - {0:f2}", procent);

                }
            }
        }

    }
}
