using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program4
    {
        public static void AvgValue()
        {
            int[]  data = new int[] { 4,12,23,45,78};

            double sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                sum = sum + data[i];
            }
            if (1 == 1)
            {
                double avg = sum / data.Length;
                Console.WriteLine("The avg of array is... " + avg);
            }
        }
        public void MinMaxValue()
        {
            int[] data = new int[] { 23,87,45,33,62 };

            int min = data[0];

            int max = data[0];

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] < min)
                {
                    min = data[i];
                }
            }

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > max)
                {
                    max = data[i];
                }
            }
            Console.WriteLine("Minimum Value of an array : " + min);
            Console.WriteLine("Maxmum Value of an array : " + max);
        }
        static void Main()
        {
            Program4 program = new Program4();
            AvgValue();
            program.MinMaxValue();
            Console.Read();
        }
    }
}
