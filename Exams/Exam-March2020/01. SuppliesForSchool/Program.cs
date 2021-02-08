using System;

namespace _01._SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double pens = 5.8;
            double markers = 7.2;
            double washer = 1.2;

            int countOfPens = int.Parse(Console.ReadLine());
            int countOfMarkers = int.Parse(Console.ReadLine());
            double litresOfWasher = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double sum = countOfPens * pens + countOfMarkers * markers + litresOfWasher * washer;
            double finaleSum = sum - (sum * discount / 100);

            Console.WriteLine($"{finaleSum:f3}");
        }
    }
}
