using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class ExachangeChar
    {
        static string Swap(string str)
        {
            if (str.Length <= 1)
                return str;
            return str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];
        }

        static void Main()
        {
            Console.WriteLine(Swap("abcd"));
            Console.WriteLine(Swap("a"));
            Console.WriteLine(Swap("xy"));
        }
    }
}
