using System;

class ForbiddenWords
{
    static void Main()
    {
        char symbol = '*';
        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        Console.WriteLine("Enter list of words separated with space");
        string word = Console.ReadLine();
        string[] forbiddenWords = word.Split(' ');
        for (int position = 0; position < forbiddenWords.Length; position++)
        {
            string currentWord = forbiddenWords[position];
            int length = currentWord.Length;
            string replace = new string (symbol, length);
            text = text.Replace(currentWord, replace);
        }

        Console.WriteLine("Changed text is: {0}", text);
    }
}