﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double centimetres = inches * 2.54;
            Console.WriteLine(centimetres);
        }
    }
}
