using System;

namespace _5.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            const double convert = 1.0;

            double result = 0;

            int numbersFrom0to9 = 0;
            int numbersFrom10to19 = 0;
            int numbersFrom20to29 = 0;
            int numbersFrom30to39 = 0;
            int numbersFrom40to50 = 0;
            int invalidNumbers = 0;

            for (int i = 1; i <= moves; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    numbersFrom0to9++;
                    if (number == 0)
                    {
                        result += 0;
                    }
                    else
                    {
                        result += number * 0.2;
                    }
                }
                else if (number >= 10 && number <= 19)
                {
                    result += number * 0.3;
                    numbersFrom10to19++;
                }
                else if (number >= 20 && number <= 29)
                {
                    result += number * 0.4;
                    numbersFrom20to29++;
                }
                else if (number >= 30 && number <= 39)
                {
                    result += 50;
                    numbersFrom30to39++;
                }
                else if (number >= 40 && number <= 50)
                {
                    result += 100;
                    numbersFrom40to50++;
                }
                else if (number > 50 || number < 0)
                {
                    result /= 2;
                    invalidNumbers++;
                }
            }



            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {((convert * numbersFrom0to9) / moves) * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {((convert * numbersFrom10to19) / moves) * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {((convert * numbersFrom20to29) / moves) * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {((convert * numbersFrom30to39) / moves) * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {((convert * numbersFrom40to50) / moves) * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {((convert * invalidNumbers) / moves) * 100:f2}%");

        }
    }
}
