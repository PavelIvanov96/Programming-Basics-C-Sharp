using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗеленчуковаБорса_26._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetable = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            double kgVegetable = double.Parse(Console.ReadLine());
            double kgFruit = double.Parse(Console.ReadLine());
            double sum = 0.0;
            double result = 0.0;

            priceVegetable = priceVegetable * kgVegetable;
            priceFruit = priceFruit * kgFruit;
            sum = priceFruit + priceVegetable;
            result = sum / 1.94;

            Console.WriteLine("{0}", result);

        }
    }
}