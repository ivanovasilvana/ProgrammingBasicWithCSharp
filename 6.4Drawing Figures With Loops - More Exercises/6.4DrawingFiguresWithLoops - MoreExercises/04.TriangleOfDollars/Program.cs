using System;

namespace _04.TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                for (int colomns = 1; colomns < rows; colomns++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine("$");
            }

        }
    }
}
