using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class ListOfNumbers
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>
            {
                3,7,12,45,65,9,1
            };

            Console.WriteLine("List of numbers : ");

            foreach (var value in list)
            {
                Console.WriteLine("{0} ", value);
            }

            var square = list.Select(x => x * x);

            Console.WriteLine("Result of greater than 20 : ");

            foreach(var res in square)
            {
                if(res>20)
                Console.WriteLine(res);
            }           
            Console.Read();
        }
    }
}
