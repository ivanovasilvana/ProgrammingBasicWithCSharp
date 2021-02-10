using System;

namespace _1.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            const double vip = 499.99;
            const double normal = 249.99;
            double ticketsMoney = 0;

            if (people >= 1 && people <= 4)
            {
                buget -= buget * 0.75;
            }

            else if (people >= 5 && people <= 9)
            {
                buget -= buget * 0.60; ;
            }

            else if (people >= 10 && people <= 24)
            {
                buget -= buget * 0.50;
            }

            else if (people >= 25 && people <= 49)
            {
                buget -= buget * 0.40;
            }

            else if (people >= 50)
            {
                buget -= buget * 0.25;
            }

            if (category == "VIP")
            {
                ticketsMoney = people * vip;
            }
            else if (category == "Normal")
            {
                ticketsMoney = people * normal;
            }
            if (buget >= ticketsMoney)
            {
                Console.WriteLine($"Yes! You have {buget - ticketsMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {ticketsMoney - buget:f2} leva.");
            }
        }
    }
}
