
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class StringLength
    {
        public static void StrLen()
        {
            Console.WriteLine("Enter the Word : ");

            String word = Console.ReadLine();

            int size = word.Length;

            Console.WriteLine("Length of the word : {0} ",size);
        }
        static void Main(string[] args)
        {
            StrLen();
            Console.Read();
        }
    }
}
