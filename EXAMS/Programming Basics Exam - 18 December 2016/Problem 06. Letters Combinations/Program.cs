using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char characterStart = char.Parse(Console.ReadLine());
            char characterEnd = char.Parse(Console.ReadLine());
            char characterSkip = char.Parse(Console.ReadLine());

            var count = 0;
            for (char firstCharacter = characterStart; firstCharacter <= characterEnd; firstCharacter++)
            {
                for (char secondCharacter = characterStart; secondCharacter <= characterEnd; secondCharacter++)
                {
                    for (char thirdCharacter = characterStart; thirdCharacter <= characterEnd; thirdCharacter++)
                    {
                        if (firstCharacter != characterSkip && secondCharacter != characterSkip && thirdCharacter != characterSkip)
                        {
                            count++;
                            Console.Write("{0}{1}{2} ", firstCharacter, secondCharacter, thirdCharacter);
                            if (firstCharacter == characterEnd && secondCharacter == characterEnd && thirdCharacter == characterEnd)
                            {
                                Console.Write(count);
                            }
                        }
                    }
                }
            }
        }
    }
}
