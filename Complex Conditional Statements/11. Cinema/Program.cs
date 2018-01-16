using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeShow = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int seats = rows * cols;
            double sum = 0;
            if (typeShow == "Premiere")
            {
                sum = seats * 12;
            }
            else if (typeShow == "Discount")
            {
                sum = seats * 5;
            }
            else if (typeShow == "Normal")
            {
                sum = seats * 7.5;
            }
            Console.WriteLine("{0:f2} leva", sum);
        }
    }
}
