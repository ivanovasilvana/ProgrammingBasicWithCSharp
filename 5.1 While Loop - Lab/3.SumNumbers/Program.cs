using System;

namespace _3.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                int currNum = int.Parse(Console.ReadLine());
                sum += currNum;
                if (sum >= target)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
