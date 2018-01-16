using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numberOfStars = 0;
            var numberOfRows = (n + 1) / 2;
            if (n % 2 == 0)
            {
                numberOfStars = 2;
            }
            else
            {
                numberOfStars = 1;
            }
            for (int i = 0; i < numberOfRows; i++)
            {
                var numberOfDashes = (n - numberOfStars) / 2;
                Console.Write(new string('-', numberOfDashes));
                Console.Write(new string('*', numberOfStars));
                Console.WriteLine(new string('-', numberOfDashes));


                numberOfStars += 2;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', n - 2));
                Console.WriteLine(new string('|', 1));
            }
        }
    }
}
