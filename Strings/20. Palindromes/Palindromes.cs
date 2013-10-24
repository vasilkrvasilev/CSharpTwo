using System;
using System.Text;

class Palindromes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter text");
        string input = Console.ReadLine();
        string[] words = input.Split(
            new char[] { ' ', ',', '.', '!', '?', '@', ':', ';', '/', '-', '(', ')', '"' },
            StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Symmetric words (palindromes) in the text are:");
        foreach (string word in words)
        {
            int length = word.Length;
            bool isSymmetric = true;
            for (int letter = 0; letter < ((length / 2) - 1); letter++)
            {
                if (word[letter] != word[length - 1 - letter])
                {
                    isSymmetric = false;
                    break;
                }
            }

            if (isSymmetric)
            {
                Console.WriteLine(word);
            }
        }
    }
}