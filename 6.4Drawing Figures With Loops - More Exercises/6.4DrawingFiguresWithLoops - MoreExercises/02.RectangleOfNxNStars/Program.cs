using System;

namespace _02.RectangleOfNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int columns = 1; columns <= n; columns++)
            {
                for (int rows = 1; rows < n; rows++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}
