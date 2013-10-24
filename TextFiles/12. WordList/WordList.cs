using System;
using System.IO;
using System.Text;

class WordList
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

    static void RewriteText(string file, string[] list)
    {
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            StreamWriter writer = new StreamWriter("result.txt", true, Encoding.GetEncoding("UTF-8"));
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    for (int currentWord = 0; currentWord < list.Length; currentWord++)
                    {
                        string word = list[currentWord];
                        string wholeWord = string.Format(" {0} ", word);
                        line = line.Replace(wholeWord, " ");
                    }

                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
    
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter file name (instead \\ use \\\\)");
            string file = Console.ReadLine();                                   ////text.txt
            Console.WriteLine("Enter list file name (instead \\ use \\\\)");
            string listFile = Console.ReadLine();                               ////list.txt
            Console.WriteLine("Enter text");
            EnterText(file);
            Console.WriteLine("Enter list of words separated with space");
            EnterText(listFile);
            string[] list;
            StreamReader reader = new StreamReader(listFile, Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                string listText = reader.ReadToEnd();
                list = listText.Split(new char[]{' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            }

            RewriteText(file, list);
        }
        catch (UnauthorizedAccessException uaae)
        {
            Console.WriteLine("You are not authorized to open this file");
            Console.WriteLine(uaae.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine("You enter invalid data");
            Console.WriteLine(ae.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine("You enter very long file name. It must be less than 248 symbols");
            Console.WriteLine(ptle.Message);
        }
        catch (NullReferenceException nre)
        {
            Console.WriteLine("File is empty or a variable has null value");
            Console.WriteLine(nre.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine("You enter invalid file name");
            Console.WriteLine(nse.Message);
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
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Cannot find the file");
            Console.WriteLine(fnfe.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.Error.WriteLine("Cannot find the directory");
            Console.WriteLine(dnfe.Message);
        }
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