using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program6
    {
        public static void CopyElements()
        {
            Console.WriteLine("Enter the array size:");

            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Enter " + size + " Elements : ");

            for(int i = 0; i <= array.Length - 1; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] array1 = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[i];
            }

            Console.WriteLine("Elements of original array:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.WriteLine();

            Console.WriteLine("Elements of New array:");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i]+" ");
            }
            
            Console.WriteLine();
        }
        static void Main(String[] args)
        {
            CopyElements();
            Console.Read();
        }
    }
}
