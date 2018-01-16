using System.Reflection;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RectangIeArea
{
    class RectangIeAreaExercise
    {
        static void Main(string[] args)
        {
            var firstside = double.
                Parse(System.Console.ReadLine());
            var secondside = double.
                Parse(System.Console.ReadLine());
            var area = firstside * secondside;
            System.Console.WriteLine(area);
        }
    }
}
