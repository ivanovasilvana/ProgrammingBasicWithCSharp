using System;

namespace _1.NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 7; i<=997; i ++)
            {
                if (i%10==5)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
