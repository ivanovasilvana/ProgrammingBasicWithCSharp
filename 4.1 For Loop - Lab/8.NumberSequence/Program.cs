using System;

namespace _8.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int smallest = int.MaxValue;

            for(int i=0; i<count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number>biggest)
                {
                    biggest = number;
                }
                if(number<smallest)
                {
                    smallest = number;

                }

            }
                Console.WriteLine($"Max number: {biggest}");
                Console.WriteLine($"Min number: {smallest}");
        }
    }
}
