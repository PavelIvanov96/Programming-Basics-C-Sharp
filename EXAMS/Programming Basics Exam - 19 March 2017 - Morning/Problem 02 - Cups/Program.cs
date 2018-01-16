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
            int numberOfCups = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int numberOfWorkdays = int.Parse(Console.ReadLine());

            double workHour = numberOfWorkdays * numberOfWorkers * 8;
            double makeCup = workHour / 5;
            double differense = Math.Floor(Math.Abs(numberOfCups - makeCup));
            double losses = (differense * 4.2);

            if (makeCup < numberOfCups)
            {
                Console.WriteLine("Losses: {0:f2}", losses);
            }
            else
            {
                Console.WriteLine("{0:f2} extra money", losses);
            }
        }
    }
}
