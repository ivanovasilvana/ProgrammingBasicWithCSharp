using System;

namespace _10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOneBgn = int.Parse(Console.ReadLine());
            int countOfTwoBgn = int.Parse(Console.ReadLine());
            int countOfFiveBgn = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int counterOne = 0;
            int counterTwo = 0;
            int counterFive = 0;

            for (int five = 0; five <= countOfFiveBgn; five++)
            {
                counterFive++;
                currentSum += five * 5;
                for (int two = 0; two <= countOfTwoBgn; two++)
                {
                    counterTwo++;
                    currentSum += two * 2;
                    for (int one = 0; 0 <= countOfOneBgn; one++)
                    {
                        counterOne++;
                        currentSum += one;
                        if (currentSum == sum)
                        {
                            Console.WriteLine($"{counterOne} * 1 lv. + {counterTwo} * 2 lv. + {counterFive} * 5 lv. = {sum}lv.");
                        }
                    }
                }
            }
        }
    }
}
