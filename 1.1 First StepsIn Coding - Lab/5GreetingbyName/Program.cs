using System;

namespace GreetingbyName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата име на човек 
            string name = Console.ReadLine();
            //и отпечатва "Hello, <name>!", където<name> е въведеното име от конзолата.
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
