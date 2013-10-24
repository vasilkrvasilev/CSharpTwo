using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DurankulakNumbers
{
    class DurankulakNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> digits = new List<string>();
            string currentDigit = string.Empty;
            for (int letter = 0; letter < input.Length; letter++)
			{
                if (char.IsLower(input[letter]))
                {
                    currentDigit += input[letter];
                }
                else if (char.IsUpper(input[letter]))
                {
                    currentDigit += input[letter];
                    digits.Add(currentDigit);
                    currentDigit = string.Empty;
                }
			}

            string alphabet = "abcdefghijklmnopqrstufvxyz";
            BigInteger number = 0;
            int power = 0;
            for (int count = digits.Count - 1; count >= 0; count--)
            {
                int currentNumber = 0;
                string digit = digits[count];
                if (digit.Length == 1)
                {
                    currentNumber += alphabet.IndexOf(digits[count].ToLower());
                }
                else if (digit.Length == 2)
                {

                    currentNumber += (alphabet.IndexOf(char.ToLower(digits[count][1])) +
                        26 * (alphabet.IndexOf(char.ToLower(digits[count][0])) + 1));
                }
                for (int pow = 0; pow < power; pow++)
                {
                    currentNumber *= 168; 
                }
                number += currentNumber;
                power++;
            }
            Console.WriteLine(number);
        }
    }
}
