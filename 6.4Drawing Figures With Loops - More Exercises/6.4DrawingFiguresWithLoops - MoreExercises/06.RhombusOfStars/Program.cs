using System;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = 1; columns <= n - rows; columns++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int columns = 1; columns < rows; columns++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int rows = n - 1; rows >= 1; rows--)
            {
                for (int columns = n - rows; columns >= 1; columns--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int columns = rows - 1; columns >= 1; columns--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
