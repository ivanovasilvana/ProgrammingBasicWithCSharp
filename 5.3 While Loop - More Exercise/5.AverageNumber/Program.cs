using System;

namespace _5.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            double average = 0;
            int sumNumber = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumNumber += number;
            }
            average = (sumNumber * 1.0) / (countOfNumbers * 1.0);
            Console.WriteLine($"{average:f2}");
        }
    }
}
