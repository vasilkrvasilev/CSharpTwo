using System;
using System.IO;
using System.Text;

class ReadFile
{
    static void Main()
    {
        Console.WriteLine("Enter full file name (instead \\ use \\\\)");
        string file = Console.ReadLine();
        try
        {
            string readText = File.ReadAllText(file, Encoding.GetEncoding("UTF-8"));
            Console.WriteLine(readText);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine("You did not enter file name");
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine("You enter invalid file name");
            Console.WriteLine(ae.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine("You enter invalid file name");
            Console.WriteLine(nse.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine("You enter very long file name. It must be less than 248 symbols");
            Console.WriteLine(ptle.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("Cannot find the file");
            Console.WriteLine(fnfe.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine("Cannot find the directory");
            Console.WriteLine(dnfe.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine("Cannot open the file");
            Console.WriteLine(ioe.Message);
        }
        catch (UnauthorizedAccessException uaae)
        {
            Console.WriteLine("You cannot open this file");
            Console.WriteLine(uaae.Message);
        }
        catch (System.Security.SecurityException se)
        {
            Console.WriteLine("You cannot open this file");
            Console.WriteLine(se.Message);
        }
    }
}