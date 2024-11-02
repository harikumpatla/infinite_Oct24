using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program5
    {
        static void Main(String[] args)
        {
            int[] data = new int[10] { 12, 78, 54, 34, 86, 42, 99, 25, 60, 143 };

            int size = data.Length;

            int total = 0;

            for (int i = 0; i < data.Length; i++)
            {
                total += data[i];
            }

            double avg = data.Average();

            int max = data.Max();

            int min = data.Min();

            Console.WriteLine("1. Total = " + total);

            Console.WriteLine("2. Average = " + avg);

            Console.WriteLine("3. Maximum = " + max);

            Console.WriteLine("4. Minimum = " + min);

            Array.Sort(data);

            Console.WriteLine("5. Marks in ascending order :");


            foreach (int asc in data)
            {
                Console.WriteLine(asc);

            }

            Array.Reverse(data);

            Console.WriteLine("6. Marks in descending order :");


            foreach (int dsc in data)
            {
                Console.WriteLine(dsc);

            }
            Console.Read();
        }
    }
}
