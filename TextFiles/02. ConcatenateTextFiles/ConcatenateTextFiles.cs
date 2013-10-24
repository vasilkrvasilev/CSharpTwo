using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        Console.WriteLine("Enter first file name (instead \\ use \\\\)");
        string firstFile = Console.ReadLine();                                  ////firsttext.txt
        Console.WriteLine("Enter second file name (instead \\ use \\\\)");
        string secondFile = Console.ReadLine();                                 ////secondtext.txt
        Console.WriteLine("Enter written file name (instead \\ use \\\\)");
        string writtenFile = Console.ReadLine();                                ////writtentext.txt
        StreamReader firstReader = new StreamReader(firstFile, Encoding.GetEncoding("UTF-8"));
        using (firstReader)
        {
            StreamWriter writer = new StreamWriter(writtenFile, true, Encoding.GetEncoding("UTF-8"));
            using (writer)
            {
                string firstFileContent = firstReader.ReadLine();
                while (firstFileContent != null)
                {
                    writer.WriteLine(firstFileContent);
                    firstFileContent = firstReader.ReadLine();
                }
            }
        }

        StreamReader secondReader = new StreamReader(secondFile, Encoding.GetEncoding("UTF-8"));
        using (secondReader)
        {
            StreamWriter writer = new StreamWriter(writtenFile, true, Encoding.GetEncoding("UTF-8"));
            using (writer)
            {
                string secondFileContent = secondReader.ReadLine();
                while (secondFileContent != null)
                {
                    writer.WriteLine(secondFileContent);
                    secondFileContent = secondReader.ReadLine();
                }
            }
        }
    }
}