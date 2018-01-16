using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double areaOfHouse = double.Parse(Console.ReadLine());
            double numberOfWindows = double.Parse(Console.ReadLine());
            double styrofoamArea = double.Parse(Console.ReadLine());
            double priceStyrofoam = double.Parse(Console.ReadLine());

            double areaHouse = areaOfHouse - (numberOfWindows * 2.4);
            double sumArea = areaHouse * 0.10 + areaHouse;
            double needetStyrofoam = Math.Ceiling(sumArea / styrofoamArea);
            double price = Math.Abs(needetStyrofoam * priceStyrofoam);
            double difference = Math.Abs(budget - price);
            if (price <= budget)
            {

                Console.WriteLine("Spent: {0:f2}", price);
                Console.WriteLine("Left: {0:f2}", difference);
            }
            if (price > budget)
            {
                Console.WriteLine("Need more: {0:f2}", difference);
            }


        }
    }
}
