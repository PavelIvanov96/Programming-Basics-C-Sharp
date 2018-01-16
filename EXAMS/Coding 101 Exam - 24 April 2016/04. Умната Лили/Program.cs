using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_SmartLily___24_April_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLily = int.Parse(Console.ReadLine());
            double priceWashingmashine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());


            double savingMoney = 0;
            int count = 0;
            int countOfToy = 1;
            var sum = 0.0;
            var difference = 0.0;

            for (int i = 1; i < ageLily; i++)
            {
                if (i % 2 == 0)
                {
                    countOfToy++;

                }
                else
                {
                    count++;
                    savingMoney = 10 * count + savingMoney;
                }
            }

            sum = savingMoney + countOfToy * priceToy - count;

            if (sum >= priceWashingmashine)
            {
                difference = sum - priceWashingmashine;

                Console.WriteLine("Yes! {0:f2}", difference);
            }
            else if (sum < priceWashingmashine)
            {
                difference = priceWashingmashine - sum;
                Console.WriteLine("No! {0:f2}", difference);
            }
        }
    }
}
