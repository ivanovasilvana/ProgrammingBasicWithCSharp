using System;

namespace _04MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inPutValue = Console.ReadLine();
            string outPutValue = Console.ReadLine();
            if (inPutValue == "mm" && outPutValue == "cm")
            {
                number /= 10;
            }
            else if (inPutValue == "mm" && outPutValue == "m") 
            {
                number /= 1000;
            }
            else if (inPutValue == "cm" && outPutValue == "mm")
            {
                number *= 10;
            }
            else if (inPutValue == "cm" && outPutValue == "m")
            {
                number /= 100;
            }
            else if (inPutValue == "m" && outPutValue == "mm")
            {
                number *= 1000;
            }
            else if (inPutValue == "m" && outPutValue == "cm")
            {
                number *= 100;
            }
            Console.WriteLine($"{number:f3}");
        }
    }
}
