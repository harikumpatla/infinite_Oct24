using System;

namespace ClassLibrary
{
    public class Calculate
    {
        public const int total_fare = 500;
        public void CalculateConcession(int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("Little Champ are you eligible for Free Ticket");
            }
            else if (age > 60)
            { 
                float concession = total_fare * 30 / 100;
                Console.WriteLine("Senior Citizen :" + concession);
            }
            else
            {
                Console.WriteLine("Ticket Booked : "+ total_fare);
            }
        }
    }
}
