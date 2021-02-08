using System;

namespace _6OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            string theOperator = Console.ReadLine();
            double result = 0;
           
                switch (theOperator)
                {
                    case "+":
                        result = numberOne + numberTwo;
                        if(result%2==0)
                        {
                            Console.WriteLine($"{numberOne} + {numberTwo} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{numberOne} + {numberTwo} = {result} - odd");
                        }
                        break;
                    case "*":
                        result = numberOne * numberTwo;
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{numberOne} * {numberTwo} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{numberOne} * {numberTwo} = {result} - odd");
                        }
                        break;
                    case "-":
                        result = numberOne - numberTwo;
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{numberOne} - {numberTwo} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{numberOne} - {numberTwo} = {result} - odd");
                        }
                        break;
                    case "/":
                    if (numberTwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberOne} by zero");
                    }
                    else
                    {
                        result = numberOne / numberTwo;
                        Console.WriteLine($"{numberOne} / {numberTwo} = {result:f2}");
                    }
                        break;
                    
                    case "%":
                    if (numberTwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberOne} by zero");
                    }
                    else
                    {
                        result = numberOne % numberTwo;
                        Console.WriteLine($"{numberOne} % {numberTwo} = {result}");
                    }
                        break;
                }
                   
            }
        }
    }

