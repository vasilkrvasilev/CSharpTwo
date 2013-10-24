using System;
using System.Text;

class Frequency
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        Console.WriteLine("Enter substring");
        string substring = Console.ReadLine();
        text.ToLower();
        substring.ToLower();
        int frequency = 0;
        int index = text.IndexOf(substring);
        while (index != -1)
        {
            frequency++;
            index = text.IndexOf(substring, index + substring.Length);
        }

        Console.WriteLine("Substring {0} is repeated {1} times", substring, frequency);
    }
}