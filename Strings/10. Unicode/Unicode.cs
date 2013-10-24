using System;
using System.Text;

class Unicode
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        int length = text.Length;
        StringBuilder unicode = new StringBuilder();
        for (int sign = 0; sign < length; sign++)
        {
            int currentSign = text[sign];
            string unicodeSign = string.Format("{0:X4}", currentSign);
            unicode.Append(string.Format("\\u{0}", unicodeSign));
        }

        Console.WriteLine("Text in unicode signs: {0}", unicode);
    }
}