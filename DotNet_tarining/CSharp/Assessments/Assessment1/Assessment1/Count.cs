using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Count
    {
        static int Occurrences(string str, char ch)
        {
            int count = 0;
            foreach (char c in str.ToLower())
            {
                if (c == char.ToLower(ch))
                {
                    count++;

                }

            }
            return count;
        }

        static void Main()
        {
            Console.WriteLine("Enter a string :");
            string str = Console.ReadLine();

            Console.WriteLine("Enter a letter :");
            char l = Console.ReadLine()[0];

            Console.WriteLine("the letter appears :{0}", Occurrences(str, l));

            Console.Read();
        }
    }
}