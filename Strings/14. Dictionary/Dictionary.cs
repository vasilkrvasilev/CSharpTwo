using System;
using System.Text;

class Dictionary
{
    static void Main()
    {
        Console.WriteLine("Enter number of words in the dictionary");
        int number = int.Parse(Console.ReadLine());
        string[] words = new string[number];
        string[] translation = new string[number];
        for (int count = 0; count < number; count++)
        {
            Console.WriteLine("Enter word");
            words[count] = Console.ReadLine();
            Console.WriteLine("Enter translation of the word");
            translation[count] = Console.ReadLine();
        }

        Console.WriteLine("Enter word for translation");
        string wordToTranslate = Console.ReadLine();
        bool found = false;
        for (int position = 0; position < number; position++)
        {
            found = wordToTranslate.Equals(words[position]);
            if (found)
            {
                Console.WriteLine(translation[position]);
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("There is no translation of this word");
        }
    }
}