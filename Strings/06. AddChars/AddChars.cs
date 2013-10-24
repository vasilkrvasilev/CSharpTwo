using System;
using System.Text;

class AddChars
{
    static void Main()
    {
        int textLength = 20;
        string symbol = "*";
        Console.WriteLine("Enter text less than {0} symbols", textLength);
        StringBuilder text = new StringBuilder(Console.ReadLine());
        int length = text.Length;
        StringBuilder addition = new StringBuilder(textLength - length);
        for (int count = 0; count < textLength - length; count++)
        {
            addition.Append(symbol);
        }
        ////Second way
        ////string addition = new string(symbol, (textLength - length));

        text.Append(addition);
        Console.WriteLine("Changed text is: {0}", text);
    }
}