using System;

namespace _07._SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isTrue = true;

            for (int A = 35; A <= 55; A++)
            {
                for (int B = 64; B <= 96; B++)
                {
                    for (int x = 1; x <= a; x++)
                    {
                        for (int y = 1; y <= b; y++)
                        {
                            counter++;
                            if (counter > max)
                            {
                                isTrue = true;
                                break;
                            }
                            Console.Write($"{Convert.ToChar(A)}{Convert.ToChar(B)}{x}{y}{Convert.ToChar(B)}{Convert.ToChar(A)}|");
                            if (x == a && y == b)
                            {
                                isTrue = true;
                                break;
                            }
                            A++;
                            if (A > 55)
                            {
                                A = 35;
                            }
                            B++;
                            if (B > 96)
                            {
                                B = 64;
                            }
                        }
                    }
                    if (isTrue)
                    {
                        break;
                    }
                }
                if (isTrue)
                {
                    break;
                }
            }

            
        }
    }
}
