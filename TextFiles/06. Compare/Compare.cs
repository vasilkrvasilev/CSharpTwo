using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Compare
{
    private class TextComparer : IComparer<string>
    {
        public int Compare(string firstWord, string secondWord)         ////First compare to the length and second lexicographically
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

    static void EnterValues(string writtenFile)
    {
        StreamWriter writer = new StreamWriter(writtenFile, true, Encoding.GetEncoding("UTF-8"));
        using (writer)
        {
            Console.WriteLine("Enter number elements");
            int elements = int.Parse(Console.ReadLine());
            writer.WriteLine(elements);
            Console.WriteLine("Enter the elements");
            for (int line = 0; line < elements; line++)
            {
                string row = Console.ReadLine();
                writer.WriteLine(row);
            }
        }
    }

    static string[] FillArray(string writtenFile)
    {
        string[] array;
        StreamReader reader = new StreamReader(writtenFile, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            string currentLine = reader.ReadLine();
            int size = int.Parse(currentLine);
            array = new string[size];
            for (int currentRow = 0; currentRow < size; currentRow++)
            {
                currentLine = reader.ReadLine();
                array[currentRow] = currentLine;
            }
        }

        return array;
    }

    static void CreateResult(string resultFile, string[] array)
    {
        StreamWriter resultWriter = new StreamWriter(resultFile, true, Encoding.GetEncoding("UTF-8"));
        using (resultWriter)
        {
            resultWriter.WriteLine("The sorted elements are:");
            for (int element = 0; element < array.Length; element++)
            {
                resultWriter.WriteLine(array[element]);
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter written file name (instead \\ use \\\\)");
        string writtenFile = Console.ReadLine();                                ////text.txt
        Console.WriteLine("Enter result file name (instead \\ use \\\\)");
        string resultFile = Console.ReadLine();                                 ////result.txt

        EnterValues(writtenFile);
        string[] array = FillArray(writtenFile);

        Array.Sort(array, (x, y) => (x).CompareTo(y));                          ////First way
        CreateResult(resultFile, array);
        Array.Sort(array, new TextComparer());                                  ////Second way
        CreateResult(resultFile, array);
    }
}