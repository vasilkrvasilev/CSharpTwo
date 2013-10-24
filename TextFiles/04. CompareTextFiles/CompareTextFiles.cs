using System;
using System.IO;
using System.Text;

class CompareTextFiles
{
    static void Main()
    {
        Console.WriteLine("Enter first file name (instead \\ use \\\\)");
        string firstFile = Console.ReadLine();                                  ////firsttext.txt
        Console.WriteLine("Enter second file name (instead \\ use \\\\)");
        string secondFile = Console.ReadLine();                                 ////secondtext.txt
        Console.WriteLine("Enter result file name (instead \\ use \\\\)");
        string resultFile = Console.ReadLine();                                 ////result.txt
        int equalLines = 0;
        int differentLines = 0;

        StreamReader firstReader = new StreamReader(firstFile, Encoding.GetEncoding("UTF-8"));
        using (firstReader)
        {
            StreamReader secondReader = new StreamReader(secondFile, Encoding.GetEncoding("UTF-8"));
            using (secondReader)
            {
                string firstFileLine = firstReader.ReadLine();
                string secondFileLine = secondReader.ReadLine();
                while (firstFileLine != null)
                {
                    bool areEqual = (firstFileLine == secondFileLine);
                    ////Second way
                    ////bool areEqual = firstFileLine.Equals(secondFileLine);
                    if (areEqual)
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }

                    firstFileLine = firstReader.ReadLine();
                    secondFileLine = secondReader.ReadLine();
                }
            }
        }

        StreamWriter writer = new StreamWriter(resultFile, false, Encoding.GetEncoding("UTF-8"));
        using (writer)
        {
            writer.WriteLine("Equal lines are {0}.\r\nDifferent lines are {1}.", equalLines, differentLines);
        }

        Console.WriteLine("Equal lines are {0}.\r\nDifferent lines are {1}.", equalLines, differentLines);
    }
}