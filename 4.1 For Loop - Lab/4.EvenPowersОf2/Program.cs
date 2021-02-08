using System;

namespace _4.EvenPowersОf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int num = 1;
           // печата четните степени на 2 ≤ 2n: 20
           for (int i=0; i<=n; i+=2)
            {
                //Console.WriteLine(num);
                Console.WriteLine("2 ^ {0} = {1}",i,num);
                num = num * 2 * 2;
            }

        }
    }
}
