using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int currentNum = row + col + 1;
                    if (currentNum > n)
                    {
                        currentNum = 2 * n - currentNum;
                    }

                    Console.Write(currentNum + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
