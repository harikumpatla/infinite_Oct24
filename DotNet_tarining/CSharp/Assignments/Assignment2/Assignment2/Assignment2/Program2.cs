using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program2
    {
        public void Sample()
        {
            Console.WriteLine("Enter a Digit: ");

            int digit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("The Output is :");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1 || i == 3)
                    {
                        Console.Write(digit + " ");
                        
                    }
                    else
                    {
                        Console.Write(digit);
                      
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program2 program = new Program2();
            program.Sample();
            Console.Read();
        }
    }
}
