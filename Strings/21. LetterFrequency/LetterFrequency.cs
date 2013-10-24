using System;
using System.Collections.Generic;
using System.Text;

class LetterFrequency
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string input = Console.ReadLine();
        StringBuilder letters = new StringBuilder();
        for (int count = 0; count < input.Length; count++)                  ////Find all letters
        {
            if (char.IsLetter(input[count]))
            {
                letters.Append(input[count]);
            }
        }

        List<char> differentLetters = new List<char>();
        List<int> frequency = new List<int>();
        bool isAlone = true;
        for (int count = 0; count < letters.Length; count++)                 ////Find all different letters and count their frequency
        {
            char currentLetter = letters[count];
            for (int position = 0; position < differentLetters.Count; position++)
            {
                if (currentLetter == differentLetters[position])
                {
                    isAlone = false;
                    frequency[position]++;
                    break;
                }
            }

            if (isAlone)
            {
                differentLetters.Add(currentLetter);
                frequency.Add(1);
            }

            isAlone = true;
        }

        Console.WriteLine("Letter in the text and how many times each of them was repeated are:");
        for (int position = 0; position < differentLetters.Count; position++)
        {
            Console.WriteLine("Letter {0} - {1} times", letters[position], frequency[position]);
        }
    }
}