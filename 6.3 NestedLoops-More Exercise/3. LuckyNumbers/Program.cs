using System;

namespace _3._LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    leftSum = i + k;

                    for (int m = 1; m <= 9; m++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            rightSum = m + l;

                            if (leftSum == rightSum && number % leftSum == 0)
                            {
                                Console.Write($"{i}{k}{m}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
