using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program3
    {
        static void Main()
        {
            Console.WriteLine("Enter any day number:");

            int day = Convert.ToChar(Console.ReadLine());

            switch (day)
            {
                case '1':
                    Console.WriteLine("Monday");
                    break;
                case '2':
                    Console.WriteLine("Tuesday");
                    break;
                case '3':
                    Console.WriteLine("Wednesday");
                    break;
                case '4':
                    Console.WriteLine("Thursday");
                    break;
                case '5':
                    Console.WriteLine("Friday");
                    break;
                case '6':
                    Console.WriteLine("Saturday");
                    break;
                case '7':
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("please Enter the valid number");
                    break;

            }

            Console.Read();
        }
    }
}
