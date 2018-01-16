using System;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareOfSTars
{
    class SquareOfStarsExercise
    {
        static void Main(string[] args)

        {
            var squereSize = int.Parse
                (Console.ReadLine());
            var fullRow = new string('*',
                squereSize);
            Console.WriteLine(fullRow);
            var squereBodyHeight =
                squereSize - 2;
            for (var i = 0;
                i < squereBodyHeight;
                i++)
            {
                Console.WriteLine("*{0}*",
                    new string(' ',
                    squereSize - 2));
            }
            Console.WriteLine(fullRow);
        }
    }
}