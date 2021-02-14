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
            bool isCFirstFound = true;
            bool isOFirstFound = true;
            bool isNFirstFound = true;

            while (input != "End")
            {
                char letter = char.Parse(input);
                if ((int) letter >= 65 && (int) letter <= 90 || (int)letter >= 97 && (int)letter <= 122 )
                {
                    if (letter == 'c' && isCFund == false && isCFirstFound == true )
                    {
                        isCFund = true;
                        isCFirstFound = false;
                    }

                    else if (letter == 'c' && isCFund == true && isCFirstFound == false)
                    {
                        result += letter;
                    }
                    if (letter == 'o' && isOFund == false && isOFirstFound == true)
                    {
                        isOFund = true;
                        isOFirstFound = false;
                    }

                    else if (letter == 'o' && isOFund == true && isOFirstFound == false)
                    {
                        result += letter;
                    }
                    if (letter == 'n' && isNFund == false && isNFirstFound == true)
                    {
                        isNFund = true;
                        isNFirstFound = false;
                    }

                    else if (letter == 'n' && isNFund == true && isNFirstFound == false)
                    {
                        result += letter;
                    }
                    else if (letter != 'n' && letter != 'c' && letter != 'o')
                    {
                        result += letter;
                    }
                    if (isCFund == true && isOFund == true && isNFund == true)
                    {
                        print += result + " ";
                        result = string.Empty;
                        isCFund = false;
                        isOFund = false;
                        isNFund = false;
                        isCFirstFound = true;
                        isOFirstFound = true;
                        isNFirstFound = true;
                    }
                }
                else
                {

                }

                input = Console.ReadLine();
            }
            Console.Write($"{print} ");
        }
    }
}
