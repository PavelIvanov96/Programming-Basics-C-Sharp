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
            double priceRoom = double.Parse(Console.ReadLine());
            double areaKitchen = double.Parse(Console.ReadLine());
            double priceMetter = double.Parse(Console.ReadLine());

            double secondRoom = priceRoom * 1.10;
            double thirdRoom = secondRoom * 1.10;
            double washRoom = priceRoom / 2;
            double sumArea = (priceRoom + areaKitchen + secondRoom + thirdRoom + washRoom) * 1.05;
            double priceHouse = priceMetter * sumArea;
            Console.WriteLine("{0:f2}", priceHouse);
        }
    }
}
