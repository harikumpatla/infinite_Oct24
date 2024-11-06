using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class LargestNum
    {
        static int FindLar(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static void Main()
        {
            Console.WriteLine(FindLar(1, 2, 3));
            Console.WriteLine(FindLar(1, 3, 4));
            Console.WriteLine(FindLar(1, 1, 1));
            Console.WriteLine(FindLar(1, 2, 2));
        }
    }
}
