using System;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        string tag = "</a>";
        string replaceTag = "[/URL]";
        text = text.Replace(tag, replaceTag);
        string startTag = "<a href=\"";
        string replaceStartTag = "[URL=";
        text = text.Replace(startTag, replaceStartTag);
        string endTag = "\">";
        string replaceEndTag = "]";
        text = text.Replace(endTag, replaceEndTag);
        Console.WriteLine("Changed text is: {0}", text);
    }
}