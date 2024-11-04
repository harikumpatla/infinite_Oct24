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
            Console.WriteLine("enter the a value : ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the b value : ");

            int b = Convert.ToInt32(Console.ReadLine());

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
