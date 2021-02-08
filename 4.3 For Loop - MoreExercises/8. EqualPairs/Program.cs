using System;

namespace _8._EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double firstSum = 0;
            double secondSum = 0;
            double diff = 0;
            double max = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double numberOne = double.Parse(Console.ReadLine());
                double numberTwo = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    firstSum = numberOne + numberTwo;
                }
                else
                {
                    secondSum = numberOne + numberTwo;
                }
                    if (i == 1)
                    {
                    firstSum = numberOne + numberTwo;
                    diff = 0;
                    }
                    else if (i >= 2)
                    {
                        diff = Math.Abs(firstSum - secondSum);

                        if (diff < max)
                        {
                            diff = max;
                        }
                    }
            
            }
                if (firstSum == secondSum)
                {
                    Console.WriteLine($"Yes, value={secondSum}");
                }
                else if (firstSum != secondSum)
                {
                    Console.WriteLine($"No, maxdiff={diff:f0}");
                }
        }
    }
}
