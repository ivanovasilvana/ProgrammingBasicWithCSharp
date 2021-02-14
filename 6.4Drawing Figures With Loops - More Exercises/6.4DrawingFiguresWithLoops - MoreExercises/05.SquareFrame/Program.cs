using System;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
            for (int k = 0; k <= n - 3; k++)
            {
                Console.Write("| ");
                for (int m = 1; m < n - 1; m++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("| ");
            }
            Console.Write("+ ");
            for (int l = 1; l <= n - 2; l++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
        }
    }
}
