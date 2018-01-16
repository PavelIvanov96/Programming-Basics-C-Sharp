using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            double kgPriceMackerel = double.Parse(Console.ReadLine());
            double kgPriceSprat = double.Parse(Console.ReadLine());
            double kgPriceBeltedBonito = double.Parse(Console.ReadLine());
            double kgPriceHorseMackerel = double.Parse(Console.ReadLine());
            double kgShellfish = double.Parse(Console.ReadLine());

            double priceBeltedBonito = kgPriceMackerel + kgPriceMackerel * 0.60;
            double sumBeltedBonito = kgPriceBeltedBonito * priceBeltedBonito;
            double priceHorseMackerel = kgPriceSprat + kgPriceSprat * 0.80;
            double sumHorseMackerel = kgPriceHorseMackerel * priceHorseMackerel;
            double sumSellfish = kgShellfish * 7.50;
            double check = sumBeltedBonito + sumHorseMackerel + sumSellfish;
            Console.WriteLine("{0:f2}", check);

        }
    }
}
