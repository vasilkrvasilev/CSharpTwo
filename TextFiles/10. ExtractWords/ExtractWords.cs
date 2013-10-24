using System;
using System.IO;
using System.Text;

class ExtractWords
{
    static void Main()
    {
        Console.WriteLine("Enter file name (instead \\ use \\\\)");
        string file = Console.ReadLine();                               ////text.txt
        string line;
        StringBuilder words = new StringBuilder();
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            line = reader.ReadLine();
            while (line != null)
            {
                int firstIndex = line.IndexOf('>');
                int secondIndex = line.IndexOf('<', firstIndex);
                while (secondIndex != -1)
                {
                    string currentWord = line.Substring(firstIndex + 1, secondIndex - firstIndex - 1);
                    words.Append(currentWord);
                    firstIndex = line.IndexOf('>', firstIndex + 1);
                    secondIndex = line.IndexOf('<', secondIndex + 1);
                }

                line = reader.ReadLine();
            }
        }

        Console.WriteLine("The text without tags is:");
        Console.WriteLine(words);
    }
}