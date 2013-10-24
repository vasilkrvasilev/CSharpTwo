using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        Console.WriteLine("Enter file name (instead \\ use \\\\)");
        string file = Console.ReadLine();                           ////text.txt
        StringBuilder changedText = new StringBuilder();
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 0)
                {
                    changedText.Append(string.Format("{0}\r\n", line));
                }

                lineNumber++;
                line = reader.ReadLine();
            }
        }

        StreamWriter writer = new StreamWriter(file, false, Encoding.GetEncoding("UTF-8"));
        using (writer)
        {
            writer.WriteLine(changedText);
        }
    }
}