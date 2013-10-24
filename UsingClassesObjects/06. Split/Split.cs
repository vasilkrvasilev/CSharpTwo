using System;

class Split
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of numbers separated by space");
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        int length = elements.Length;
        int sum = 0;

        for (int count = 0; count < length; count++)
        {
            int number = int.Parse(elements[count]);
            sum += number;
        }
        Console.WriteLine("Sum of the elements of the sequence is {0}", sum);
    }
}