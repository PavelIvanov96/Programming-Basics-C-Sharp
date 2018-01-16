using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var countFail = 0;
            var countBetween4 = 0;
            var countBetween5 = 0;
            var countOver5 = 0;
            var sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double rating = double.Parse(Console.ReadLine());


                if (rating <= 2.99)
                {
                    countFail++;
                }
                else if (rating <= 3.99)
                {
                    countBetween4++;
                }
                else if (rating <= 4.99)
                {
                    countBetween5++;
                }
                else if (rating >= 5)
                {
                    countOver5++;
                }
                rating = sum + rating;
                sum = rating;
            }
            Console.WriteLine("Top students: {0:f2}%", (double)countOver5 * 100 / n);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (double)countBetween5 * 100 / n);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (double)countBetween4 * 100 / n);
            Console.WriteLine("Fail: {0:f2}%", (double)countFail * 100 / n);
            Console.WriteLine("Average: {0:f2}", (double)sum / n);
        }
    }
}
