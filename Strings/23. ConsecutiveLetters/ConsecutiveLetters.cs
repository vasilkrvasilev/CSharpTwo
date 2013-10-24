using System;
using System.Text;

class ConsecutiveLetters
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string input = Console.ReadLine();
        for (int count = 0; count < input.Length; count++)
        {
            if (!char.IsLetter(input[count]))
            {
                input = input.Replace(input[count], ' ');
            }
        }

        StringBuilder changedText = new StringBuilder();
        StringBuilder consecutiveLetters = new StringBuilder();
        consecutiveLetters.Append(input[0]);
        for (int count = 1; count < input.Length; count++)
        {
            char currentLetter = input[count];
            if (currentLetter == consecutiveLetters[0])
            {
                consecutiveLetters.Append(currentLetter);
            }
            else
            {
                changedText.Append(consecutiveLetters[0]);
                consecutiveLetters.Clear();
                consecutiveLetters.Append(currentLetter);
            }
        }

        changedText.Append(consecutiveLetters[0]);
        Console.WriteLine("Changed text is: {0}", changedText);
    }
}