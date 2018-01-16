using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хотелска_Стая__28._08._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            double numberOfNights = double.Parse(Console.ReadLine());
            double studio = 0.0;
            double apartment = 0.0;

            if (month == "may" || month == "october")
            {
                if (numberOfNights >= 7 && numberOfNights <= 14)
                {
                    studio = (50 - ((double)50 * 5 / 100)) * numberOfNights;
                    apartment = 65 * numberOfNights;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                }
                else if (numberOfNights > 14)
                {
                    studio = (50 - ((double)50 * 30 / 100)) * numberOfNights;
                    apartment = (65 - ((double)65 / 10)) * numberOfNights;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                }
            }
            else if (month == "june" || month == "september")
            {
                if (numberOfNights > 14)
                {
                    studio = (75.20 - ((double)75.20 * 20 / 100)) * numberOfNights;
                    apartment = (68.70 - ((double)68.70 / 10)) * numberOfNights;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                }
                else if (numberOfNights < 14)
                {
                    studio = 75.20 * numberOfNights;
                    apartment = 68.70 * numberOfNights;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:F2} lv.", studio);
                }
                else if (numberOfNights == 14)
                {
                    studio = 75.20 * numberOfNights;
                    apartment = 68.70 * numberOfNights;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:F2} lv.", studio);
                }
            }
            else if (month == "july" || month == "august")
            {
                if (numberOfNights <= 14)
                {
                    studio = 76 * numberOfNights;
                    apartment = 77 * numberOfNights;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                }
                else if (numberOfNights > 14)
                {
                    studio = 76 * numberOfNights;
                    apartment = (77 - ((double)77 / 10)) * numberOfNights;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:f2} lv.", studio);

                }
            }

        }
    }
}
