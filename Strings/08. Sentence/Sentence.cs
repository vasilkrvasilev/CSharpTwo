using System;
using System.Text;

class Sentence
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string input = Console.ReadLine();
        string text = input.ToLower();
        Console.WriteLine("Enter word");
        string word = Console.ReadLine().ToLower();
        int currentPosiotion = 0;
        bool isWord = false;
        string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Sentences containing {0} are:", word);
        for (int count = 0; count < sentences.Length; count++)
        {
            string sentenceSigns = sentences[count];
            for (int position = 0; position < sentenceSigns.Length; position++)            ////Remove all punctuation
            {
                if (char.IsPunctuation(sentenceSigns[position]))
                {
                    sentenceSigns = sentenceSigns.Replace(sentenceSigns[position], ' ');
                }
            }

            string[] sentenceWords = sentenceSigns.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int currentWord = 0; currentWord < sentenceWords.Length; currentWord++)   ////Search for the word
            {
                if (sentenceWords[currentWord] == word)
                {
                    isWord = true;
                    break;
                }
            }

            if (isWord)                                                                   ////Write the sentences that contain the word
            {
                Console.WriteLine(input.Substring(currentPosiotion, sentences[count].Length + 1));                
            }

            isWord = false;
            currentPosiotion += (sentences[count].Length + 1);
        }
    }
}