﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program1
    {
        public static void TwoInteger()
        {
            Console.WriteLine("Enter The 1st Input Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The 2ND Input Number");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine(a + " and " + b + " are equal");
            }
            else
            {
                Console.WriteLine(a + " and " + b + " are not equal");
            }
        }
        static void Main(string[] args)
        {
            TwoInteger();
            Console.Read();
        }
    }
}
