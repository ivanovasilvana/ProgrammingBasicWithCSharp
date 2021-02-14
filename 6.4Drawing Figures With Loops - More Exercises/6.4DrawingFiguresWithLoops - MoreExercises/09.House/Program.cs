using System;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int roofRows = 1; roofRows <= (n + 1) / 2; roofRows++)
            {
                for (int roofCol = 1; roofCol < roofRows; roofCol++)
                {
                    if (n % 2 != 0)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine("**");
                    }
                }
            }
        }
    }
}
