using System;
using System.Globalization;
using System.Text.RegularExpressions;

class CanadaDate
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string input = Console.ReadLine();
        MatchCollection dates = Regex.Matches(input, @"\d{2}\.\d{2}\.\d{4}");
        foreach (var item in dates)
        {
            DateTime currentDate = DateTime.ParseExact(item.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("The date is {0}", currentDate.ToString(new CultureInfo("en-CA")));
        }
    }
}