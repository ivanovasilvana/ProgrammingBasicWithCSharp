using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstAndLastRow = new string('*', n * 2);
            string star = new string('*', 1);
            string line = new string('/', 2 * n - 2);
            string space = new string(' ', n);
            string verticalLine = new string('|', n);

            Console.Write(firstAndLastRow);
            Console.Write(space);
            Console.WriteLine(firstAndLastRow);
            for (int rows = 0; rows < n - 2; rows++)
            {
                Console.Write(star);
                Console.Write(line);
                Console.Write(star);
                if (rows == (n - 1) / 2 - 1)
                {
                    Console.Write(verticalLine);
                }
                else
                {
                    Console.Write(space);
                }
                Console.Write(star);
                Console.Write(line);
                Console.WriteLine(star);
            }
            Console.Write(firstAndLastRow);
            Console.Write(space);
            Console.WriteLine(firstAndLastRow);

        }
    }
}
