using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class CricketTeam
    {
        public String Pointscalculation(int matches)
        {
            int sum = 0;
            double avg = 0;
            for(int i = 1; i <= matches; i++)
            {
                Console.WriteLine($"Score {i}:");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            avg = sum / matches;
            return "Matches : " + matches + " Total : " + sum + " Avarage : " + avg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no.of Matches");
            int  matches = Convert.ToInt32(Console.ReadLine());

            CricketTeam cricketTeam = new CricketTeam();

            Console.WriteLine(cricketTeam.Pointscalculation(matches));

            Console.Read();
        }
    }
}
