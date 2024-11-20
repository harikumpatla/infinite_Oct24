using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assessment3
{
    class AppendText
    {
        public static void Main()
        {
            string filePath = "MyFile.txt";

            Console.WriteLine("Enter The Text : ");
            string text = Console.ReadLine();

            using(StreamWriter streamWriter = File.AppendText(filePath))
            {
                streamWriter.WriteLine(text);
            }

            Console.WriteLine("Task Completed....");
            Console.Read();
        }
    }
}
