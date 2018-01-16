using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 100)  // (n >= 1 && nu <= 100)
            {
                Console.WriteLine("The number is invalid");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is {0}", n);
        }
    }
}
