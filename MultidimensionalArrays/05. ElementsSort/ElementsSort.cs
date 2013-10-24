using System;
using System.Collections.Generic;

class ElementsSort
{
    private class TextComparer : IComparer<string>
    {
        public int Compare(string firstWord, string secondWord)         //First compare to the length and second lexicographically
        {
            var firstWordLength = firstWord.Length;
            var secondWordLength = secondWord.Length;
            if (firstWordLength == secondWordLength)
            {
                return firstWord.CompareTo(secondWord);
            }

            return firstWordLength.CompareTo(secondWordLength);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements");
        int elements = int.Parse(Console.ReadLine());
        string[] array = new string[elements];

        Console.WriteLine("Enter the elements of the array (text)");
        for (int position = 0; position < elements; position++)
        {
            array[position] = Console.ReadLine();
        }

        //First way using IComparer
        Array.Sort(array, new TextComparer());
        Console.WriteLine("The elements of sorted array are:");
        for (int position = 0; position < elements; position++)
        {
            Console.Write("{0} ", array[position]);
        }

        //Second way using Lambda expression
        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
        Console.WriteLine("The elements of sorted array are:");
        foreach (string text in array)
        {
            Console.Write("{0} ", text);
        }
    }
}