using System;

class LastDigitName
{
    static string NameDigit(int digit)
    {
        switch (digit)
        {
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            case 0:
                return "Zero";
            default:
                return string.Empty;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number");
        int number;
        string input = Console.ReadLine();
        bool isNumber = int.TryParse(input, out number);
        if (isNumber)
        {
            int lastDigit = number % 10;
            string digitName = NameDigit(lastDigit);
            Console.WriteLine("The name of the last digit of {0} in english is {1}", number, digitName);
        }
        else
        {
            Console.WriteLine("You enter invalid number! Try again.");
        }
    }
}