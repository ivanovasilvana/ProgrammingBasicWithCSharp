using System;

namespace _4.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isFound = false;

            for (int i = start; i <= end; i++)
            {
                for (int n = start; n <= end; n++)
                {
                    counter++;

                    if (i + n == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {n} = {magicNumber})");
                        isFound = true;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
