using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Градуси_към_фаренхайд
{
    class Program
    {
        static void Main(string[] args)
        {
            var Celsius = double.Parse(Console.ReadLine());
            var formul = Celsius * 1.8 + 32;
            Math.Round(formul, 2);
            Console.WriteLine("formul =" + formul);

        }
    }
}
