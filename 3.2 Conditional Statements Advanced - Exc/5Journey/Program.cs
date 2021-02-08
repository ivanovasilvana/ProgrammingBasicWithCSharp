using System;

namespace _5Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalMoney = 0;
            if (buget <= 100)
            {
                if (season == "summer")
                {
                    totalMoney = buget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {totalMoney:f2}");
                }
                else if (season == "winter")
                {
                    totalMoney = buget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {totalMoney:f2}");
                }
            }
            else if (buget <= 1000)
            {
                if (season == "summer")
                {
                    totalMoney = buget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {totalMoney:f2}");
                }
                else if (season == "winter")
                {
                    totalMoney = buget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {totalMoney:f2}");
                }
            }
            else if (buget > 1000)
                if (season == "summer" || season == "winter")
                {
                    totalMoney = buget * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {totalMoney:f2}");
                }
            }
        }
    }

