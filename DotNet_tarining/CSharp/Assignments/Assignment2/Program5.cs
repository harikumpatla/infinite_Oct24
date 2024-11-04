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
            Console.WriteLine("Enter the array size:");

            int size = Convert.ToInt32(Console.ReadLine());

            int[] data = new int[size];

            Console.WriteLine("Enter " + size + " Elements : ");

            for (int i = 0; i <= data.Length - 1; i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

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
