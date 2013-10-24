using System;

class LetterPosition
{
    static void Main()
    {
        Console.WriteLine("Enter word");
        string word = (Console.ReadLine()).ToLower();
        int size = word.Length;
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        int elements = 26;
        int firstElement = 0;                              //First element in the area we search
        int endElement = 25;                               //Last element in the area we search
        int middleElement = 13;                            //Middle element in the area we search

        for (int letter = 0; letter < size; letter++)      //Consecutively search for each letter of the word
        {
            while (elements > 0)
            {
                if (word[letter] == alphabet[middleElement])
                {
                    Console.WriteLine("{0} letter in {1} is the {2} from the alphabet", word[letter], word, middleElement + 1);
                    break;
                }
                else if (word[letter] < alphabet[middleElement])
                {
                    if (firstElement != middleElement)
                    {
                        endElement = middleElement - 1;
                        elements = middleElement - firstElement;
                        middleElement = firstElement + elements / 2;
                    }
                    else
                    {
                        elements = 0;
                    }
                }
                else
                {
                    if (firstElement != middleElement)
                    {
                        firstElement = middleElement + 1;
                        elements = endElement - middleElement;
                        middleElement = firstElement + elements / 2;
                    }
                    else
                    {
                        elements = 0;
                    }
                }
            }
            elements = 26;
            firstElement = 0;
            endElement = 25;
            middleElement = 13;
        }
    }
}