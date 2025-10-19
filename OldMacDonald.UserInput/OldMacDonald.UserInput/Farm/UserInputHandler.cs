using System;
using System.Text.RegularExpressions;

namespace OldMacDonald.UserInput.Farm
{
    public static class UserInputHandler
    {
        public static int PositiveNumber(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out result) && result > 0)
                    return result;

                Console.WriteLine("Please enter a valid positive number");
            }
        }

        public static string OnlyLetters(string prompt)
        {
            string? input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("This field cannot be empty. Please try again");
                    continue;
                }

                if (!Regex.IsMatch(input, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("This field must contain only letters. Please try again");
                    continue;
                }

                break;
            } while (true);

            return input!;
        }
    }
}
