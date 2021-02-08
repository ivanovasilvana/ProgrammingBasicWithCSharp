using System;

namespace _08.SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int endHundred = int.Parse(Console.ReadLine());
            int endTen = int.Parse(Console.ReadLine());
            int endOne = int.Parse(Console.ReadLine());

            for (int i = 2; i <= endHundred; i++)
            {
                for (int m = 2; m <= endTen; m++)
                {
                    for (int n = 2; n <= endOne; n++)
                    {
                        if (i % 2 == 0 && n % 2 == 0 && (m == 2 || m == 3 || m ==5 || m == 7))
                        {
                            Console.WriteLine($"{i} {m} {n}");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}
