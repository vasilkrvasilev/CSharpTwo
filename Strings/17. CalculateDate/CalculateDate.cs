using System;
using System.Globalization;
using System.Text;
using System.Threading;

class CalculateDate
{
    static void Main()
    {
        Console.WriteLine("Enter date in format dd.MM.yyyy HH:mm:ss");
        string input = Console.ReadLine();
        DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        double hours = 6;
        double minutes = 30;
        date = date.AddHours(hours);
        date = date.AddMinutes(minutes);
        Console.WriteLine("Date after {0} hours and {1} minutes is going to be {2:dd.MM.yyyy HH:mm:ss}", hours, minutes, date);
        Console.WriteLine("The day of week is {0}", date.ToString("dddd", new CultureInfo("bg-BG")));
    }
}