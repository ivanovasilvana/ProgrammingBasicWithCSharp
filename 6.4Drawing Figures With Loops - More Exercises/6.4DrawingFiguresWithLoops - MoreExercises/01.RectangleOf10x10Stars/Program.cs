using System;

namespace _01.RectangleOf10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int columns = 1; columns <= 10; columns++)
            {
                for (int rows = 1; rows < 10; rows++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }        
        }
    }
}
