using System;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Enter sentence");
        string sentence = Console.ReadLine();
        StringBuilder reverse = new StringBuilder(sentence.Length);
        StringBuilder separators = new StringBuilder();
        for (int count = 0; count < sentence.Length; count++)                   ////Save all punctuation
        {
            if (char.IsPunctuation(sentence[count]))
            {
                separators.Append(sentence[count]);
            }
        }

        string[] subSentence = sentence.Split(
            new char[] { ',', '.', '!', '?', ':', ';', '-', '(', ')', '"' }, 
            StringSplitOptions.RemoveEmptyEntries);                             ////Divide the sentence to subsentences
        int sign = 0;
        for (int part = subSentence.Length - 1; part >= 0; part--)
        {
            string currentSubSentence = subSentence[part];
            string[] words = currentSubSentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int count = words.Length - 1; count >= 0; count--)             ////Divide the subsentence to words and reverse them
            {
                reverse.Append(string.Format(" {0}", words[count]));
            }

            reverse.Append(separators[sign]);
            sign++;
        }

        Console.WriteLine("Reverse sentence is: {0}", reverse);
    }
}