using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int fact = 1;

            do
            {
                fact *= num;
                num--;
            } while (num > 1);
            Console.WriteLine(fact);
        }
    }
}
