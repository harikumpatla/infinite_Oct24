using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program3
    {
        static void Main(String[] args)
        { 
            Console.WriteLine("Enter The 1st Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The SIGN");
            char s = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter The 2nd Number");
            int b = Convert.ToInt32(Console.ReadLine());
            
            switch (s)
            {
                case '+':
                    Console.WriteLine("The Addition of " +a+ " and "+b+" = "+(a+b));
                    break;
                case '-':
                    Console.WriteLine("The Substraction of " + a + " and " + b + " = " + (a - b));
                    break;
                case '*':
                    Console.WriteLine("The Multiplication of " + a + " and " + b + " = " + (a * b));
                    break;
                case '/':
                    Console.WriteLine("The Division of " + a + " and " + b + " = " + (a / b));
                    break;
                default:
                    Console.WriteLine("Invalid Type");
                    break;
            }
            Console.Read();
        }
    }
}
