using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TirDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double kilometersForMonth = double.Parse(Console.ReadLine());

            var kmPrice = 0.0;
            var differenceProcent = 0.0;

            if (kilometersForMonth <= 5000)
            {
                if (season == "summer")
                {
                    kmPrice = kilometersForMonth * 0.90 * 4;
                    differenceProcent = kmPrice - (kmPrice * 0.1);
                    Console.WriteLine("{0:f2}", differenceProcent);

                }
                else if (season == "winter")
                {
                    kmPrice = kilometersForMonth * 1.05 * 4;
                    differenceProcent = kmPrice - (kmPrice * 0.1);
                    Console.WriteLine("{0:f2}", differenceProcent);
                }
                else if (season == "spring" || season == "autumn")
                {
                    kmPrice = kilometersForMonth * 0.75 * 4;
                    differenceProcent = kmPrice - (kmPrice * 0.1);
                    Console.WriteLine("{0:f2}", differenceProcent);
                }

            }
            else if (kilometersForMonth > 5000 && kilometersForMonth <= 10000)
            {
                if (season == "summer")
                {
                    kmPrice = kilometersForMonth * 1.10 * 4;
                    differenceProcent = kmPrice - (kmPrice * 0.1);
                    Console.WriteLine("{0:f2}", differenceProcent);

                }
                else if (season == "winter")
                {
                    kmPrice = kilometersForMonth * 1.25 * 4;
                    differenceProcent = kmPrice - (kmPrice * 0.1);
                    Console.WriteLine("{0:f2}", differenceProcent);
                }
                else if (season == "spring" || season == "autumn")
                {
                    kmPrice = kilometersForMonth * 0.95 * 4;
                    differenceProcent = kmPrice - (kmPrice * 0.1);
                    Console.WriteLine("{0:f2}", differenceProcent);
                }
            }
            else if (kilometersForMonth > 10000 && kilometersForMonth <= 20000)
            {
                if (season == "winter" || season == "summer" || season == "autumn" || season == "spring")
                {
                    kmPrice = kilometersForMonth * 1.45 * 4;
                    differenceProcent = kmPrice - (kmPrice * 0.1);
                    Console.WriteLine("{0:f2}", differenceProcent);
                }
            }

        }
    }
}
