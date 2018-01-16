using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MonthCost
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());

            var sum = 0.0;

            var water = month * 20;
            var network = month * 15;
            var average = 0.0;
            var other = 0.0;
            var procent = 0.0;

            for (int i = 1; i <= month; i++)
            {
                double checkForMonth = double.Parse(Console.ReadLine());

                checkForMonth = sum + checkForMonth;
                sum = checkForMonth;


                if (i == month)
                {

                    Console.WriteLine("Electricity: {0:f2} lv", checkForMonth);
                    Console.WriteLine("Water: {0:f2} lv", water);
                    Console.WriteLine("Internet: {0:f2} lv", network);
                    procent = (checkForMonth + (month * 35)) * 0.2;
                    other = procent + checkForMonth + month * 35;
                    Console.WriteLine("Other: {0:f2} lv", other);
                    average = (checkForMonth + water + network + other) / month;
                    Console.WriteLine("Average: {0:f2} lv", average);
                }


            }

        }
    }
}
