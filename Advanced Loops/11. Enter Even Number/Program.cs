using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {
                try
                {
                    int num = int.Parse(Console.ReadLine());



                    if (num % 2 == 0)
                    {
                        Console.WriteLine("this is the number :" + num);
                        break;
                    }

                    Console.WriteLine("The number is not even.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input.");
                }
            }


        }
    }
}
