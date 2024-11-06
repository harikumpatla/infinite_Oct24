using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class RemoveChar
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word : ");
            String word = Console.ReadLine();

            Console.WriteLine("enter the index number :");
            int index = Convert.ToInt32(Console.ReadLine());
            
            String s = " ";
            for (int i = 0; i < word.Length; i++)
            {
                if (index != 0)
                {
                    if (index != i)
                    {
                        s = s + word[i];
                    }
                }
                else if (index == 0)
                {
                    Console.WriteLine(word);
                    break;
                }
            }
            Console.WriteLine(s);

            Console.Read();
        }
    }
}
