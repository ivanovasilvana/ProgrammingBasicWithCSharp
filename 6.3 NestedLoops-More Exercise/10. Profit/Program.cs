using System;

namespace _10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOne = int.Parse(Console.ReadLine());
            int countTwo = int.Parse(Console.ReadLine());
            int countFive = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());


            for (int one = 0; one <= countOne; one++)
            {

                for (int two = 0; two <= countTwo; two++)
                {

                    for (int five = 0; five <= countFive; five++)
                    {
                        if (one * 1 + two * 2 + five * 5 == sum)
                        {
                            Console.WriteLine($"{one}*1 lv. + {two}*2 lv. + {five}*5 lv. = {sum}lv.");
                        }
                    }
                }
            }

        }
    }
}
