using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1; // 2 ^ 0 

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(result);
                result *= 2;
            }
            // Console.WriteLine(result);
        }
    }
}
