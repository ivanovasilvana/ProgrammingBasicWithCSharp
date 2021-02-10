using System;

namespace SimpleCalculationExc
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollarsCourse = 1.79549;
            double dollars = double.Parse(Console.ReadLine());
            double convertToBGN = dollars * dollarsCourse;
            Console.WriteLine($"{convertToBGN:f2}");
        }
    }
}