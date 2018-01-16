using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_17._07._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoint = double.Parse(Console.ReadLine());
            double yen = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());


            double bitcointToLeva = bitcoint * 1168;
            double yenToDollar = yen * 0.15;
            double dollarToLeva = yenToDollar * 1.76;

            double levaToEuro = (bitcointToLeva + dollarToLeva) / 1.95;
            double result = levaToEuro - (levaToEuro * (commission / 100));

            Console.WriteLine("{0}", result);



        }
    }
}
