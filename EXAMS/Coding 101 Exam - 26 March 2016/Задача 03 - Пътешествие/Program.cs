using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_Travelling__26.March._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            double spentMoney = 0.0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria ");
                if (season == "summer")
                {
                    spentMoney = budget * 30 / 100;
                    Console.WriteLine("Camp - {0:f2}", spentMoney);
                }
                else
                {
                    spentMoney = budget * 70 / 100;
                    Console.WriteLine("Hotel - {0:f2}", spentMoney);
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans ");
                if (season == "summer")
                {
                    spentMoney = budget * 40 / 100;
                    Console.WriteLine("Camp - {0:f2}", spentMoney);
                }
                else
                {
                    spentMoney = budget * 80 / 100;
                    Console.WriteLine("Hotel - {0:f2}", spentMoney);
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                spentMoney = budget * 90 / 100;
                Console.WriteLine("Hotel - {0:f2}", spentMoney);
            }


        }
    }
}
