using System;
using System.Globalization;
using System.Text;

class CalculatePeriod
{
    static void Main()
    {
        Console.WriteLine("Enter date in format dd.MM.yyyy");
        string firstInput = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(firstInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Enter date in format dd.MM.yyyy");
        string secondInput = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(secondInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        TimeSpan period = secondDate.Subtract(firstDate);
        Console.WriteLine("The period between {0:dd.MM.yyyy} and {1:dd.MM.yyyy} is {2:dd} days", firstDate, secondDate, period);
    }
}