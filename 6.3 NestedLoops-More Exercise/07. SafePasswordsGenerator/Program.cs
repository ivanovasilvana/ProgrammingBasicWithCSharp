﻿using System;

namespace _07._SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int currentCombination = 0;
            for (int A = 35; A <= 55; A++)
            {
                for (int B = 64; B <= 96; B++)
                {
                    for (int x = 1; x <= a; x++)
                    {
                        for (int y = 1; y <= b; y++)
                        {
                            currentCombination++;
                            Console.WriteLine($"{Convert.ToChar(A)}{Convert.ToChar(B)}{x}{y}{Convert.ToChar(B)}{Convert.ToChar(A)}|");
                            if (x == a && y == b)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
