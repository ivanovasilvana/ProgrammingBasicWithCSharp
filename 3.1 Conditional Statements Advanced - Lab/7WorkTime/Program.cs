using System;

namespace _7WorkTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":

                    if (hour >= 10 && hour <= 18)
                    {
                        Console.WriteLine("open");
                    }

                    else
                    {
                        Console.WriteLine("closed");

                    }
                    break;
                case "Saturday":
                case "Sunday":

                    Console.WriteLine("closed");
                    break;
            }

        }
    }
}
