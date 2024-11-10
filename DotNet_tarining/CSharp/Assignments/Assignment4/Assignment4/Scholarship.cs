using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Scholarship
    {
        public void Merit()
        {
            Console.WriteLine("Enter the marks :");

            int marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the fee :");

            int fee = Convert.ToInt32(Console.ReadLine());

            float f1 = 0.2f;

            float f2 = 0.3f;

            float f3 = 0.5f;


            if(marks >= 70 && marks<= 80)
            {
                float amount =  f1 * fee;

                Console.WriteLine("scholarship amount : "+ amount);
            }

            else if (marks > 80 && marks <= 90)
            {
                float amount = f2 * fee;

                Console.WriteLine("scholarship amount : " + amount);
            }

            else if (marks > 90)
            {
                float amount = f3 * fee;

                Console.WriteLine("scholarship amount : " + amount);
            }

            else
            {
                Console.WriteLine("You are not eligible for scholarship");
            }
        }

        public static void Main()
        {
            Scholarship scholarship = new Scholarship();

            scholarship.Merit();

            Console.Read();
        }
    }
}
