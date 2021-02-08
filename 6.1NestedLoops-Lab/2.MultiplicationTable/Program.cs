using System;

namespace _2.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int n = 1; n < 11; n++)
                {
                    Console.WriteLine($"{i} * {n} = {i * n}");
                }
            }
        }
    }
}
