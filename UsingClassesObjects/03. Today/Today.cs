using System;

class Today
{
    static void Main()
    {
        Console.WriteLine("Enter year");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter month");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter day");
        int day = int.Parse(Console.ReadLine());
        DateTime today = new DateTime(year, month, day);
        Console.WriteLine("Today is {0}", today.DayOfWeek);
    }
}