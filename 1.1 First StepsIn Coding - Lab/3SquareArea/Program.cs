using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Конзолата чете страната на квадрата:
            int side = int.Parse(Console.ReadLine());
            //Конзолата отпечатва страната на квадрата:
            int area = side*side;
            Console.WriteLine(area);
        }
    }
}
