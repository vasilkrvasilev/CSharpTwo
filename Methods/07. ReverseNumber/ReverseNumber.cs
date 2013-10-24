using System;

class ReverseNumber
{
    static string Reverse(int number, string changedNumber)
    {
        int lastDigit = number % 10;
        changedNumber += lastDigit.ToString();
        return changedNumber;
    }

    static void Main()
    {
        Console.WriteLine("Enter number");
        string input = Console.ReadLine();
        int number;
        bool isNumber = int.TryParse(input, out number);
        string changedNumber = string.Empty;
        if (isNumber)
        {
            for (int count = 0; count < input.Length; count++)
            {
                changedNumber = Reverse(number, changedNumber);
                number /= 10;
            }

            Console.WriteLine("Reversed number is {0}", changedNumber);
        }
        else
        {
            Console.WriteLine("You enter invalid number! Try again!");
        }
    }
}