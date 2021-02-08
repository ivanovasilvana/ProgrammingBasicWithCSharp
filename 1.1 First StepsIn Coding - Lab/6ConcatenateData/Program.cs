using System;

namespace ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която прочита от конзолата име, фамилия, възраст и град
            string firstName = (Console.ReadLine());
            string lastName = (Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string town = (Console.ReadLine());
            //печата съобщение от следния вид:
            //"You are <firstName> <lastName>, a <age>-years old person from <town>."
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
