using System;
using System.Text;

class List
{
    static void Main()
    {
        Console.WriteLine("Enter words separated by space");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        Array.Sort(words);
        Console.WriteLine("Words ordered lexicographically:");
        for (int count = 0; count < words.Length; count++)
        {
            Console.WriteLine(words[count]);
        }
    }
}