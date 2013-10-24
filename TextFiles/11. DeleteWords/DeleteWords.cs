using System;
using System.IO;
using System.Text;

class DeleteWords
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter file name (instead \\ use \\\\)");
            string file = Console.ReadLine();                               ////text.txt
            StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                StreamWriter writer = new StreamWriter("result.txt", true, Encoding.GetEncoding("UTF-8"));
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        int firstIndex = line.IndexOf(" test");
                        int secondIndex = line.IndexOf(" ", firstIndex + 5);
                        while (firstIndex != -1)
                        {
                            string partOne = line.Substring(0, firstIndex);
                            string partTwo = line.Substring(secondIndex, line.Length - secondIndex);
                            line = string.Format("{0}{1}", partOne, partTwo);
                            firstIndex = line.IndexOf(" test");
                            secondIndex = line.IndexOf(" ", firstIndex + 5);
                        }

                        firstIndex = line.IndexOf("Test");
                        secondIndex = line.IndexOf(" ", firstIndex + 1);
                        while (firstIndex != -1)
                        {
                            string partOne = line.Substring(0, firstIndex);
                            string partTwo = line.Substring(secondIndex, line.Length - secondIndex);
                            line = string.Format("{0}{1}", partOne, partTwo);
                            firstIndex = line.IndexOf("Test");
                            secondIndex = line.IndexOf(" ", firstIndex + 5);
                        }

                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine("You enter invalid data");
            Console.WriteLine(ae.Message);
        }
        catch (UnauthorizedAccessException uaae)
        {
            Console.WriteLine("You are not authorized to open this file");
            Console.WriteLine(uaae.Message);
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
        catch (IOException ioe)
        {
            Console.WriteLine("Cannot open the file");
            Console.WriteLine(ioe.Message);
        }
    }
}