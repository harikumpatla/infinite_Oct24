using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program4
    {
        static void Main()
        {
            Console.WriteLine("Enter The Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i));
              
            }
            Console.Read();
        }
    }
}
