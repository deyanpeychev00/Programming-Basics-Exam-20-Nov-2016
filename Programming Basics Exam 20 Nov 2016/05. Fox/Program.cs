using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5.Лисица
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            var dash = ((2 * n) + 3) - (2 * stars) - 2;

            //upper part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', stars));
                Console.Write('\\');
                Console.Write(new string('-', dash));
                Console.Write('/');
                Console.WriteLine(new string('*', stars));
                dash -= 2;
                stars++;
            }
            //middle part
            var leftRightStars = n / 2;
            var middleStars = ((2 * n) + 3) - (2 * leftRightStars) - 4;
            for (int i = 0; i < n / 3; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', leftRightStars));
                Console.Write('\\');
                Console.Write(new string('*', middleStars));
                Console.Write('/');
                Console.Write(new string('*', leftRightStars));
                Console.WriteLine('|');
                leftRightStars++;
                middleStars -= 2;
            }
            //lower part
            var outerDashes = 1;
            middleStars = ((2 * n) + 3) - (2 * outerDashes) - 2;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', outerDashes));
                Console.Write('\\');
                Console.Write(new string('*', middleStars));
                Console.Write('/');
                Console.WriteLine(new string('-', outerDashes));
                outerDashes++;
                middleStars -= 2;
            }
        }
    }
}
