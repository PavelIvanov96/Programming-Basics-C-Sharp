using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Радиани_в_Градуси
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var formul = (Math.Floor(rad * 180 / Math.PI));
            Console.WriteLine("formul =" + formul);

        }
    }
}
