using System;
using System.Collections.Generic;
using System.Text;

class WordFrequency
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string input = Console.ReadLine();
        for (int count = 0; count < input.Length; count++)              ////Separate all words with spase
        {
            if (!char.IsLetter(input[count]) && (input[count] != '\''))
            {
                input = input.Replace(input[count], ' ');
            }
        }

        string[] text = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> words = new List<string>();
        List<int> frequency = new List<int>();
        bool isAlone = true;
        for (int count = 0; count < text.Length; count++)               ////Find different words and count their frecuency
        {
            string currentWord = text[count];
            for (int position = 0; position < words.Count; position++)
            {
                if (currentWord == words[position])
                {
                    isAlone = false;
                    frequency[position]++;
                    break;
                }
            }

            if (isAlone)
            {
                words.Add(currentWord);
                frequency.Add(1);
            }

            isAlone = true;
        }

        Console.WriteLine("Words in the text and how many times each of them was repeated are:");
        for (int position = 0; position < words.Count; position++)
        {
            Console.WriteLine("Word {0} - {1} times", words[position], frequency[position]);
        }
    }
}