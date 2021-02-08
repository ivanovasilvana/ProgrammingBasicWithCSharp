using System;

namespace _09._SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            bool isFound = false;
            for (int i = start; i <= end; i++)
            {
                for (int m = start; m <= end; m++)
                {
                    counter++;
                    sum = i + m;
                    if (sum == magicNum)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {m} = {magicNum})");
                        
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
            
        }
    }
}
