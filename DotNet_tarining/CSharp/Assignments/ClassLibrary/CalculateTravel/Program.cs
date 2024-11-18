using System;
using ClassLibrary;

namespace CalculateTravel
{
    class Program
    {
        public const int total_fare = 500;
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            Console.WriteLine("Enter your Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Age : ");

            int age = Convert.ToInt32(Console.ReadLine());

            calculate.CalculateConcession(age);
            Console.Read();
        }
    }
}
