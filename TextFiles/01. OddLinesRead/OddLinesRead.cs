using System;
using System.IO;
using System.Text;

class OddLinesRead
{
    static void Main()
    {
        Console.WriteLine("Enter file name (instead \\ use \\\\)");
        string file = Console.ReadLine();                                                 ////text.txt
        Console.WriteLine("The odd lines of the file contain following text:");
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 0)
                {
                    Console.WriteLine(line);
                }

                line = reader.ReadLine();
                lineNumber++;
            }
        }
    }
}