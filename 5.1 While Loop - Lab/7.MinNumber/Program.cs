using System;

namespace _7.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }

                int number = int.Parse(input);

                if (number < min)
                {
                   min = number;
                }
            }
            Console.WriteLine(min);
        }
    }
}
