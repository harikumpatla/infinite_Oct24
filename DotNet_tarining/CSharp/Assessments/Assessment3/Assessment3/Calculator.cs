using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    delegate int Calculators(int a, int b);
    class Calculator
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Mul(int a, int b)
        {
            return a * b;
        }

        public static void Main()
        {
            Console.WriteLine("Enter the First number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Calculators calculators;

            calculators = Add;
            Console.WriteLine("Addition : "+ calculators(num1,num2));

            calculators = Sub;
            Console.WriteLine("Substraction : " + calculators(num1, num2));

            calculators = Mul;
            Console.WriteLine("Multiplication : " + calculators(num1, num2));

            Console.Read();
        }
    }
}
