using System;

namespace _6.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometres = double.Parse(Console.ReadLine());

            double money = 0;

            if (kilometres <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    money = kilometres * 0.75;
                }
                else if (season == "Summer")
                {
                    money = kilometres * 0.9;
                }
                else if (season == "Winter")
                {
                    money = kilometres * 1.05;
                }
            }
            else if (kilometres > 5000 && kilometres <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    money = kilometres * 0.95;
                }
                else if (season == "Summer")
                {
                    money = kilometres * 1.1;
                }
                else if (season == "Winter")
                {
                    money = kilometres * 1.25;
                }
            }
            else if (kilometres > 10000 && kilometres <= 20000)
            {
                if (season == "Spring" || season == "Autumn" || season == "Summer" || season == "Winter")
                {
                    money = kilometres * 1.45;
                }
            }
            double salary = 4 * (money - (money * 0.1));
            Console.WriteLine($"{salary:f2}");
        }
    }
}
