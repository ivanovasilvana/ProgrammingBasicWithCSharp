using System;

namespace _13._PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startOne = int.Parse(Console.ReadLine());
            int startTwo = int.Parse(Console.ReadLine());
            //разлика между началната и крайната стойност:
            int diffOne = int.Parse(Console.ReadLine());
            int diffTwo = int.Parse(Console.ReadLine());

            int endOne = startOne + diffOne;
            int endTwo = startTwo + diffTwo;
            int counter = 0;

            for (int numberOne = startOne; numberOne <= endOne; numberOne++)
            {
                for (int numberTwo = startTwo; numberTwo <= endTwo; numberTwo++)
                {
                    bool isNumberOnePrime = true;
                    bool isNumberTwoPrime = true;

                    for (int i = 2; i <=Math.Sqrt(numberOne); i++)
                    {
                        if (numberOne % i == 0)
                        {
                            isNumberOnePrime = false;
                            break;
                        }
                    }

                    for (int j = 2; j <= Math.Sqrt(numberTwo); j++)
                    {
                        if (numberTwo % j == 0)
                        {
                            isNumberTwoPrime = false;
                            break;
                        }
                    }

                    if (isNumberOnePrime && isNumberTwoPrime)
                    {
                        Console.WriteLine($"{numberOne}{numberTwo}");
                    }
                }
            }
        }
    }
}
