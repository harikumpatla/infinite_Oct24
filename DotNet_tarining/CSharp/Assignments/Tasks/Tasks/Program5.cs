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
          
           Program5.Sample();
        }
        public static void Sample()
        {
            Console.WriteLine("Enter The first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            if (num1 == num2)
            {
                sum = sum * 3;
                
            }
            Console.WriteLine(sum);
            Console.Read();           
        }    
    }
}
