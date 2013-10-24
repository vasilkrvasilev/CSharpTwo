using System;
using System.IO;
using System.Text;

class ExtractText
{
    static void Main()
    {
        Console.WriteLine("Enter file name (instead \\ use \\\\)");
        string file = Console.ReadLine();                               ////text.txt
        string line;
        Console.WriteLine("The text without tags is:");
        StringBuilder words = new StringBuilder();
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            line = reader.ReadLine();
            while (line != null)
            {
                int firstIndex = line.IndexOf('<');
                int secondIndex = line.IndexOf('>');
                if (firstIndex == -1 && secondIndex == -1)                 ////text without tags
                {
                    Console.WriteLine(line);
                }
                else if (firstIndex != -1 && secondIndex == -1)            ////text <tag
                {
                    Console.WriteLine(line.Substring(0, firstIndex));
                }
                else if (firstIndex == -1 && secondIndex != -1)            ////tag> text
                {
                    Console.WriteLine(line.Substring(secondIndex + 1, line.Length - secondIndex - 1));
                }
                else
                {
                    if (firstIndex < secondIndex)                          ////text <tag> text
                    {
                        Console.Write(line.Substring(0, firstIndex));
                        while (secondIndex != -1)
                        {
                            firstIndex = line.IndexOf('<', secondIndex);
                            if (firstIndex != -1)
                            {
                                string currentWord = line.Substring(secondIndex + 1, firstIndex - secondIndex - 1);
                                words.Append(currentWord);
                                secondIndex = line.IndexOf('>', firstIndex);
                            }
                            else
                            {
                                words.Append(line.Substring(secondIndex + 1, line.Length - secondIndex - 1));
                                break;
                            }
                        }

                        Console.WriteLine(words);
                        words.Clear();
                    }
                    else
                    {                                                       ////tag> text <tag
                        Console.Write(line.Substring(secondIndex + 1, firstIndex - secondIndex - 1));
                        secondIndex = line.IndexOf('>', firstIndex);
                        while (secondIndex != -1)
                        {
                            firstIndex = line.IndexOf('<', secondIndex);
                            if (firstIndex != -1)
                            {
                                string currentWord = line.Substring(secondIndex + 1, firstIndex - secondIndex - 1);
                                words.Append(currentWord);
                                secondIndex = line.IndexOf('>', secondIndex + 1);
                            }
                            else
                            {
                                words.Append(line.Substring(secondIndex + 1, line.Length - secondIndex - 1));
                                break;
                            }
                        }
                    }
                }

                line = reader.ReadLine();
            }
        }
    }
}