using System;
using System.IO;
using System.Text;

class ReplaceWord
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
        string line;
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            StreamWriter resultWriter = new StreamWriter("result.txt", true, Encoding.GetEncoding("UTF-8"));
            using (resultWriter)
            {
                line = reader.ReadLine();
                while (line != null)
                {
                    line = line.Replace("Start ", "Finish ");
                    line = line.Replace(" start ", " finish ");
                    line = line.Replace(" start.", " finish.");
                    resultWriter.WriteLine(line);
                    line = reader.ReadLine();
                }
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