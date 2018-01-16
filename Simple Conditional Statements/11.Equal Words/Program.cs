using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            word1 = word1.ToLower();
            word2 = word2.ToLower();

            if (word1.Equals(word2))
            {
                Console.WriteLine("yes");
            }
            else
            { Console.WriteLine("no"); }


        }
    }
}
