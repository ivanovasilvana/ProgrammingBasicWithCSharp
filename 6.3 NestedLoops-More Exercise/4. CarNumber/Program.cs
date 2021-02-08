using System;

namespace _4._CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                for (int k = start; k <= end; k++)
                {
                    for (int l = start; l <= end; l++)
                    {
                        sum = k + l;
                        for (int m = start; m <= end; m++)
                        {
                            if (i % 2 == 0)
                            {
                                if (m % 2 != 0)
                                {
                                    if (i > m && sum % 2 == 0)
                                    {
                                        Console.Write($"{i}{k}{l}{m} ");
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                if (m % 2 == 0)
                                {
                                    if (i > m && sum % 2 == 0)
                                    {
                                        Console.Write($"{i}{k}{l}{m} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
