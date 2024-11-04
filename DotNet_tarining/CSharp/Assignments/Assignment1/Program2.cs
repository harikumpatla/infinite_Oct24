using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter The Given Number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 0)
            {
                Console.WriteLine("{0} is a Positive Number",a);
            }
            else if(a < 0)
            {
                Console.WriteLine("{0} is a Negative Number",a);
            }
            Console.Read();
        }

    }
}
