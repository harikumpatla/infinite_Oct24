using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Count
    {
        public static void CountFile()
        {
            FileStream fileStream = new FileStream("MyFile.txt", FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(fileStream);

            string path = @"C:\Hari_infinite\DotNet_tarining\CSharp\Assignments\Assignment5\Assignment5\bin\Debug\MyFile.txt";

            if(File.Exists(path))
            {
                int count = File.ReadAllLines(path).Length;
                Console.WriteLine("Number of Lines :" + count);
            }
            else
            {
                Console.WriteLine("File Does Not Exists......");
            }
        }
        static void Main()
        {
            CountFile();
            Console.Read();
        }
    }
}
