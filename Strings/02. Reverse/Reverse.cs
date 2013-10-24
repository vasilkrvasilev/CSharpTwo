using System;
using System.Text;

class Reverse
{
    static void Main()
    {
        Console.WriteLine("Enter phrase");
        string input = Console.ReadLine();
        int length = input.Length;
        StringBuilder reverse = new StringBuilder(length);
        for (int letter = length - 1; letter >= 0; letter--)
        {
            reverse.Append(input[letter]);
        }

        Console.WriteLine();
        Console.WriteLine("The reversed phrase is:\n\r{0}", reverse);
    }
}