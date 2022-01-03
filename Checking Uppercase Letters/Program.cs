using System;
using static System.Console;

namespace Checking_Uppercase_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            string inputString;
            const char QUIT = '!';
            Write("Enter an uppercase letter: ");
            inputString = ReadLine();
            letter = Convert.ToChar(inputString);

            while(letter != '!')
            {
                if (letter >= 'A' && letter <= 'Z')
                    WriteLine("OK");
                else
                    WriteLine("Sorry -- that was not an uppercase letter");
                WriteLine("Enter an uppercase letter or {0} to quite: ", QUIT);
                inputString = ReadLine();
                letter = Convert.ToChar(inputString);

            }
        }
    }
}
