using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class NegativeNumber
    {
        static void CheckNegativeNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("the number cannot be negative");
            }
            else
            {
                Console.WriteLine("the number is positive");
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter the number");
            try
            {
                int number = int.Parse(Console.ReadLine());
                CheckNegativeNumber(number);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception :" + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine(" enter a proper valid integer");
            }
            Console.Read();
        }
    }
}
