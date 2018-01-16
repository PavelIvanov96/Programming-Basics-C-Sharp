using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДневнаПечалба_17._07._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double workDay = double.Parse(Console.ReadLine());
            double earnedMoneyforDay = double.Parse(Console.ReadLine());
            double courseofDollartoLeva = double.Parse(Console.ReadLine());

            double earnedMoneyforMonth = workDay * earnedMoneyforDay;
            double earnedMoneyforYear = earnedMoneyforMonth * 12 + earnedMoneyforMonth * 2.5;
            double taxOfMoneyforYear = 0.25 * earnedMoneyforYear;
            double netIncomeforYear = (earnedMoneyforYear - taxOfMoneyforYear) * courseofDollartoLeva;
            double result = netIncomeforYear / 365;

            Console.WriteLine("{0:0.00}", result);
        }
    }
}
