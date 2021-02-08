using System;

namespace _1.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumeInLitres = int.Parse(Console.ReadLine());
            int pOne = int.Parse(Console.ReadLine());
            int pTwo = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipeOne = pOne * hours;
            double pipeTwo = pTwo * hours;

            double litres = pipeOne + pipeTwo;

            if (litres <= volumeInLitres)
            {
                double procents = (litres / volumeInLitres)*100;
                double procenstsPipeOne = (pipeOne/litres)*100;
                double procenstsPipeTwo = (pipeTwo / litres) * 100;
                Console.WriteLine($"The pool is {procents:f2}% full. Pipe 1: {procenstsPipeOne:f2}%. Pipe 2: {procenstsPipeTwo:f2}%.");
            }
            else
            {
                double litresOverflows = litres - volumeInLitres;
                Console.WriteLine($"For {hours} hours the pool overflows with {litresOverflows:f2} liters.");
            }
        }
    }
}
