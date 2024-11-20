using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class Box
    {
        public double Length, Breadth;

        public void Add(Box b1 , Box b2)
        {
            Length = b1.Length + b2.Length;

            Breadth = b1.Breadth + b2.Breadth;
        }

        public void Display()
        {
            Console.WriteLine("length : " + Length + " Breadth : "+ Breadth);
        }
    }
    class Sample
    {
        public static void Main()
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();

            Console.WriteLine("Enter the Box 1 Length :");

            box1.Length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Box 1 Breadth :");

            box1.Breadth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Box 2 Length :");

            box2.Length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Box 2 Breadth :");

            box2.Breadth = Convert.ToDouble(Console.ReadLine());

            box3.Add(box1, box2);

            Console.WriteLine("\nBox 3 : ");
            box3.Display();

            Console.ReadLine();
        }
    }
}
