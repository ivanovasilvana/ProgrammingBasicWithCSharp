using System;

namespace _2._LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char escape = char.Parse(Console.ReadLine());

            int count = 0;

            for (char i = start; i <= end; i++)
            {
                for (char k = start; k <= end; k++)
                {
                    for (char m = start; m <= end; m++)
                    {
                        if (i == escape || k == escape || m == escape)
                        {
                            continue;
                        }

                        else
                        {
                            count++;
                            Console.Write($"{i}{k}{m} ");
                        }
                    }
                }
            }
            Console.Write(count);
        }
    }
}
