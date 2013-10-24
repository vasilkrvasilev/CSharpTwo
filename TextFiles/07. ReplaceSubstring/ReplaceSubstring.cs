using System;
using System.IO;
using System.Text;

class ReplaceSubstring
{
    static void EnterText(string file)
    {
        StreamWriter writer = new StreamWriter(file, false, Encoding.GetEncoding("UTF-8"));
        using (writer)
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            writer.WriteLine(text);
        }
    }

    static void ReadText(string file)
    {
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                line = line.Replace("start", "finish");
                StreamWriter resiltWriter = new StreamWriter("result.txt", true, Encoding.GetEncoding("UTF-8"));
                using (resiltWriter)
                {
                    resiltWriter.WriteLine("{0}\r\n", line);
                }

                line = reader.ReadLine();
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter file name (instead \\ use \\\\) - different from result.txt");
        string file = Console.ReadLine();                               ////text.txt
        EnterText(file);
        ReadText(file);
    }
}