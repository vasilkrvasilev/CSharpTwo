using System;
using System.IO;
using System.Text;

class WordsCount
{
    static void EnterText(string file)
    {
        StreamWriter writer = new StreamWriter(file, false, Encoding.GetEncoding("UTF-8"));
        using (writer)
        {
            string text = Console.ReadLine();
            writer.WriteLine(text);
        }
    }

    static int CountFrequency(string file, string word)
    {
        int currentFrequency = 0;
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] content = line.Split(new char[]{' ', ',', '.', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
                for (int count = 0; count < content.Length; count++)
                {
                    if (content[count] == word)
                    {
                        currentFrequency++;
                    }
                }

                line = reader.ReadLine();
            }
        }

        return currentFrequency;
    }

    static void WriteResult(string[] list, int[] frequency)
    {
        int maxFrequency = -1;
        int elementPosition = 0;
        StreamWriter writer = new StreamWriter("result.txt", true, Encoding.GetEncoding("UTF-8"));
        using (writer)
        {
            for (int count = 0; count < list.Length; count++)
            {
                for (int position = 0; position < list.Length; position++)
                {
                    if (frequency[position] > maxFrequency)
                    {
                        maxFrequency = frequency[position];
                        elementPosition = position;
                    }
                }

                writer.WriteLine("Word \"{0}\" is repeated {1} times", list[elementPosition], frequency[elementPosition]);
                frequency[elementPosition] = -2;
                maxFrequency = -1;
            }
        }
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Enter text");
            EnterText("test.txt");
            Console.WriteLine("Enter list of words separated with space");
            EnterText("words.txt");
            string[] list;
            StreamReader reader = new StreamReader("words.txt", Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                string listText = reader.ReadToEnd();
                list = listText.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            int[] frequency = new int[list.Length];
            for (int currentWord = 0; currentWord < list.Length; currentWord++)
            {
                string word = list[currentWord];
                frequency[currentWord] = CountFrequency("test.txt", word);
            }

            WriteResult(list, frequency);
        }
        catch (NullReferenceException nre)
        {
            Console.WriteLine("File is empty or a variable has null value");
            Console.WriteLine(nre.Message);
        }
        catch (StackOverflowException sofe)
        {
            Console.WriteLine("Unexpected error occur.");
            Console.WriteLine(sofe.Message);
            Console.WriteLine("Please restart the program and try again.");
        }
        catch (OutOfMemoryException ofme)
        {
            Console.WriteLine("Unexpected error occur.");
            Console.WriteLine(ofme.Message);
            Console.WriteLine("Please restart the program and try again.");
        }
        catch (UnauthorizedAccessException uaae)
        {
            Console.WriteLine("You are not authorized to open this file");
            Console.WriteLine(uaae.Message);
        }
        ////catch (FileNotFoundException fnfe)
        ////{
        ////    Console.WriteLine("Cannot find the file");
        ////    Console.WriteLine(fnfe.Message);
        ////}
        ////catch (DirectoryNotFoundException dnfe)
        ////{
        ////    Console.Error.WriteLine("Cannot find the directory");
        ////    Console.WriteLine(dnfe.Message);
        ////}
        catch (IOException ioe)
        {
            Console.WriteLine("Cannot open the file");
            Console.WriteLine(ioe.Message);
        }
        catch (System.Security.SecurityException se)
        {
            Console.WriteLine("You cannot open this file");
            Console.WriteLine(se.Message);
        }
    }
}