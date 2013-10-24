using System;
using System.Text;

class ToUpper
{
    static void Main()
    {
        Console.WriteLine("Enter text with tags");
        string text = Console.ReadLine();
        string startTag = "<upcase>";
        string endTag = "</upcase>";
        int startIndex = text.IndexOf(startTag);
        int endIndex = text.IndexOf(endTag);
        while (startIndex != -1)                ////Find the subsstring between both tags and replace it without the tags
        {
            string middleToRaplace = text.Substring(startIndex, endIndex + endTag.Length - startIndex);
            string middle = text.Substring(startIndex + startTag.Length, endIndex - startIndex - startTag.Length);
            middle = middle.ToUpper();
            text = text.Replace(middleToRaplace, middle);
            startIndex = text.IndexOf(startTag);
            endIndex = text.IndexOf(endTag);
        }

        Console.WriteLine("Text without tags is: {0}", text);
    }
}