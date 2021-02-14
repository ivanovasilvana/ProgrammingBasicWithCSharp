using System;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                string stars = new string('*', i);
                string space = new string(' ', n - i);
                Console.Write(space);
                Console.Write(stars);
                Console.Write(" | ");
                Console.Write(stars);
                Console.WriteLine(space);
            }
        }

    }
}
