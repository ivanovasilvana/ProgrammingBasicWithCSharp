using System;

namespace _04._TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGrups = int.Parse(Console.ReadLine());

            int sumPeople = 0;
            double musala = 0;
            double monblan = 0;
            double kilimajaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 1; i <= countOfGrups; i++)
            {
                int countOfPeople = int.Parse(Console.ReadLine());
                sumPeople += countOfPeople;
                if (countOfPeople <= 5)
                {
                    musala += countOfPeople;
                }
                else if (countOfPeople >= 6 && countOfPeople <= 12)
                {
                    monblan += countOfPeople;
                }
                else if (countOfPeople >= 13 && countOfPeople <= 25)
                {
                    kilimajaro += countOfPeople;
                }
                else if (countOfPeople >= 26 && countOfPeople <= 40)
                {
                    k2 += countOfPeople;
                }
                else
                {
                    everest += countOfPeople;
                }
            }
            Console.WriteLine($"{musala / sumPeople * 100:f2}%");
            Console.WriteLine($"{monblan / sumPeople * 100:f2}%");
            Console.WriteLine($"{kilimajaro / sumPeople * 100:f2}%");
            Console.WriteLine($"{k2 / sumPeople * 100:f2}%");
            Console.WriteLine($"{everest / sumPeople * 100:f2}%");
        }
    }
}
