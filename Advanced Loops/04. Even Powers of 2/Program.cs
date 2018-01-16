using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            Console.WriteLine(result);
            for (int i = 0; i < n / 2; i++)
            {
                result *= 4;
                Console.WriteLine(result);
            }
        }
    }
}
