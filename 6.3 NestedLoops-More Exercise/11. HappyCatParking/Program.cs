using System;

namespace _11._HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sum = 0;
            double finaleSum = 0;
            double priceForDay = 0;

            for (int i = 1; i <= days; i++)
            {
                for (int h = 1; h <= hours; h++)
                {
                    if (i % 2 == 0 && h % 2 != 0)
                    {
                        sum = 2.5;
                    }

                    else if (i % 2 != 0 && h % 2 == 0)
                    {
                        sum = 1.25;
                    }

                    else
                    {
                        sum = 1;
                    }

                    priceForDay += sum;
                    finaleSum += sum;
                }
                Console.WriteLine($"Day: {i} - {priceForDay:f2} leva");
                priceForDay = 0;
            }
            Console.WriteLine($"Total: {finaleSum:f2} leva");
        }
    }
}
