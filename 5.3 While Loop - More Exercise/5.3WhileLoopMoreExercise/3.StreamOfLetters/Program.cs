using System;

namespace _3.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            string print = "";

            bool isCFund = false;
            bool isOFund = false;
            bool isNFund = false;
            bool isFirstFound = false;

            while (input != "End")
            {
                char letter = input[0];
                bool isLetter = char.IsLetter(letter);

                if (!isLetter)
                {
                    input = Console.ReadLine();
                    continue;
                }

                else
                {
                    if (letter == 'n')
                }
            }
        }
    }
}
