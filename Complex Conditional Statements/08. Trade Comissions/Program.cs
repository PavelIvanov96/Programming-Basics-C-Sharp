using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double comission = -1;


            if (city == "sofia")

            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.05 * sales;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.07 * sales;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.08 * sales;
                }
                else if (sales > 10000)
                {
                    comission = 0.12 * sales;
                }

            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.045 * sales;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.075 * sales;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.10 * sales;
                }
                else if (sales > 10000)
                {
                    comission = 0.13 * sales;
                }
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.055 * sales;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.08 * sales;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.12 * sales;
                }
                else if (sales > 10000)
                {
                    comission = 0.145 * sales;
                }
            }
            if (comission >= 0)
            {
                Console.WriteLine("{0:f2}", comission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
