using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program1
    {
        public static void SwapNumbers()
        {
            int a = 25;

            int b = 56;

            Console.WriteLine("Before swaping of Two numbers " + " a = "+ a + " , b = "+ b);

            int swap = a;

            a = b;

            b = swap;
            Console.WriteLine();

            Console.WriteLine("After swaping of Two numbers " + " a = " + a + " , b = " + b);
        }
        static void Main(string[] args)
        {
            SwapNumbers();
            Console.Read();
        }
    }
}
