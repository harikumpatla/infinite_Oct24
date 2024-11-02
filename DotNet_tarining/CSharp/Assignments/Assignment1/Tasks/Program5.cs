using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program5
    {
        static void Main()
        {
            int result = Program5.Sample();
            Console.WriteLine("The Triple of sum is :" + result);
            Console.Read();
          
        }
        public static int Sample()
        {
            Console.WriteLine("Enter The first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int Tsum =0;
            if (num1 == num2)
            {
                Tsum = sum * 3;         
            }         
            return Tsum;                      
        }    
    }
}
