using System;

namespace a10.MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double result = number * 2;
            if (number < 0)
            {
                Console.WriteLine("Negative number!");
            }
            else
            {
                Console.WriteLine($"Result: {result:F2}");
            }  
            while (number >= 0)
            {
                number = double.Parse(Console.ReadLine());
                result = number * 2;
                if (number >= 0)
                {
                    Console.WriteLine($"Result: {result:F2}");
                }
                else
                {
                    Console.WriteLine("Negative number!");
                }
            }
        }
    }
}
