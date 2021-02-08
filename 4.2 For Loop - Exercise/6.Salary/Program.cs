using System;

namespace _6.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int facebook = 150;
            const int instagram = 100;
            const int reddit = 50;

            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= openTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    break;
                }

                string sites = Console.ReadLine();
                if (sites == "Facebook")
                {
                    salary -= facebook;
                }
                else if (sites == "Instagram")
                {
                    salary -= instagram;
                }
                else if (sites == "Reddit")
                {
                    salary -= reddit;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary:f0}");
            }
        }

    }
}
