using System;
using System.IO;
using System.Text;

class URLAddress
{
    static void Main()
    {
        Console.WriteLine("Enter URL address");
        string input = Console.ReadLine();
        int indexOfProtocol = input.IndexOf(':');
        string protocol = input.Substring(0, indexOfProtocol);
        int firstIndex = input.IndexOf('/');
        int secondIndex = input.IndexOf('/', firstIndex + 2);
        string server = input.Substring(firstIndex + 2, secondIndex - firstIndex - 2);
        string resourse = input.Substring(secondIndex, input.Length - secondIndex);
        Console.WriteLine("Protocol: {0}\r\nServer: {1}\r\nResourse: {2}", protocol, server, resourse);
    }
}