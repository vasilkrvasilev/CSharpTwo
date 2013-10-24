using System;
using System.IO;
using System.Text;

class NumberLines
{
    static void Main()
    {
        Console.WriteLine("Enter file name (instead \\ use \\\\)");
        string file = Console.ReadLine();                                       ////text.txt
        Console.WriteLine("Enter written file name (instead \\ use \\\\)");
        string writtenFile = Console.ReadLine();                                ////writtentext.txt
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            StreamWriter writer = new StreamWriter(writtenFile, true, Encoding.GetEncoding("UTF-8"));
            using (writer)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}