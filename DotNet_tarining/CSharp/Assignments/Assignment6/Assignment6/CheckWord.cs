using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class CheckWord
    {
        public string Name { get; set; }

        public static List<CheckWord> GetNames()
        {
            List<CheckWord> nameList = new List<CheckWord>()
            {
                new CheckWord{Name="hari"},
                new CheckWord{Name="vasu"},
                new CheckWord{Name="padma"},
                new CheckWord{Name="krishna"},
                new CheckWord{Name="kanaya"},

            };
            return nameList;
        }

    }

    class Word
    {
        static void Main()
        {
            IEnumerable<string> name = from compare in CheckWord.GetNames()
                                          where compare.Name.StartsWith("k") & compare.Name.EndsWith("a")
                                          select compare.Name;

            foreach (var n in name)
            {
                Console.WriteLine("Name : "+n);
            }
            Console.Read();
        }

    }
}
