using System;

namespace _04._CatFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfcats = int.Parse(Console.ReadLine());
            double food = 0;
            int countCat1 = 0;
            int countCat2 = 0;
            int countCat3 = 0;
            double eatenFood = 0;

            for (int i = 1; i <= countOfcats; i++)
            {
                food = double.Parse(Console.ReadLine());
                eatenFood += food;

                if (food >= 100 && food < 200)
                {
                    countCat1++;
                }
                else if (food >= 200 && food  < 300)
                {
                    countCat2++;
                }
                else if (food >= 300 && food < 400)
                {
                    countCat3++;
                }
            }
            double price = (eatenFood / 1000) * 12.45;
            Console.WriteLine($"Group 1: {countCat1} cats.");
            Console.WriteLine($"Group 2: {countCat2} cats.");
            Console.WriteLine($"Group 3: {countCat3} cats.");
            Console.WriteLine($"Price for food per day: {price:f2} lv.");
        }
    }
}