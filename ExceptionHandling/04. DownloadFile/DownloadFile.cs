using System;
using System.Net;
using System.Text;

class DownloadFile
{
    static void Main()
    {
        Console.WriteLine("Enter full web address");
        string web = Console.ReadLine();                    //"http://www.devbg.org/img/Logo-BASD.jpg"
        Console.WriteLine("Enter destination file name");
        string file = Console.ReadLine();
        try
        {
            WebClient client = new WebClient();
            using (client)
            {
                client.DownloadFile(web, file);
            }
        }
        catch (WebException we)
        {
            Console.WriteLine("You enter invalid web address");
            Console.WriteLine(we.Message);
        }
        catch (System.Security.SecurityException se)
        {
            Console.WriteLine("You cannot open this file");
            Console.WriteLine(se.Message);
        }
    }
}