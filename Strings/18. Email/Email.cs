using System;
using System.Text;
using System.Text.RegularExpressions;

class Email
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string input = Console.ReadLine();
        MatchCollection email = Regex.Matches(input, @"\w+@\w+\.\w+");
        Console.WriteLine("Email addresses in the text are:");
        foreach (var item in email)
        {
            Console.WriteLine(item);
        }
    }
}