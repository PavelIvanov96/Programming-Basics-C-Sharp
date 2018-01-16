using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GrapeAndRikia
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaGrape = double.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            double loss = double.Parse(Console.ReadLine());

            double grapeKg = areaGrape * kg;
            double lossDifferense = grapeKg - loss;
            double grapeForRikia = 0.45 * lossDifferense;
            double rikiaForPripek = grapeForRikia / 7.5;
            double incomeByRikia = rikiaForPripek * 9.80;

            double grapeForSell = 0.55 * lossDifferense;
            double incomeByGrape = grapeForSell * 1.50;

            Console.WriteLine("{0:f2}", incomeByRikia);
            Console.WriteLine("{0:f2}", incomeByGrape);
        }
    }
}
