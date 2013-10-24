using System;
using System.Text;

class Code
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        int length = text.Length;
        Console.WriteLine("Enter cipher");
        string cipher = Console.ReadLine();
        int cipherLength = cipher.Length;
        int repeat = length / cipherLength;
        int lastLetters = length % cipherLength;

        StringBuilder code = new StringBuilder(length);
        for (int count = 0; count < repeat; count++)
        {
            code.Append(cipher);
        }

        code.Append(cipher.Substring(0, lastLetters));
        StringBuilder encoded = new StringBuilder(length);
        for (int sign = 0; sign < length; sign++)
        {
            char encodedSymbol = (char)(text[sign] ^ code[sign]);
            encoded.Append(encodedSymbol);
        }

        StringBuilder decoded = new StringBuilder(length);
        for (int sign = 0; sign < length; sign++)
        {
            char decodedSymbol = (char)(encoded[sign] ^ code[sign]);
            decoded.Append(decodedSymbol);
        }

        Console.WriteLine("Encoded text is: {0}", encoded);
        Console.WriteLine("Decoded text is: {0}", decoded);
    }
}