using System;

namespace _12._TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlValue = int.Parse(Console.ReadLine());

            int count = 0;
            int password = 0;
            bool isFound = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (controlValue == (a * b + c * d) && a < b && c > d)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                count++;

                                if (count == 4)
                                {
                                    isFound = true;
                                    password = 1000 * a + 100 * b + 10 * c + d;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();

            if (isFound)
            {
                Console.WriteLine($"Password: {password}");
            }

            else
            {
                Console.WriteLine($"No!");
            }
        }
    }
}
