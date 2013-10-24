using System;

class WorkDays
{
    static void Main()
    {
        DateTime today = DateTime.Today;
        Console.WriteLine("Enter year");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter month");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter day");
        int day = int.Parse(Console.ReadLine());
        DateTime endDate = new DateTime(year, month, day);
        int workdays = 0;

        for (DateTime date = today; date < endDate; date = date.AddDays(1.0))
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    workdays++;
                    break;
                case DayOfWeek.Tuesday:
                    workdays++;
                    break;
                case DayOfWeek.Wednesday:
                    workdays++;
                    break;
                case DayOfWeek.Thursday:
                    workdays++;
                    break;
                case DayOfWeek.Friday:
                    workdays++;
                    break;
            }
            bool isHoliday = date.Equals(new DateTime(year, 1, 1)) || date.Equals(new DateTime(year, 3, 3)) ||
                date.Equals(new DateTime(year, 5, 1)) || date.Equals(new DateTime(year, 5, 6)) ||
                date.Equals(new DateTime(year, 5, 24)) || date.Equals(new DateTime(year, 9, 6)) ||
                date.Equals(new DateTime(year, 9, 22)) || date.Equals(new DateTime(year, 12, 24)) ||
                date.Equals(new DateTime(year, 12, 25)) || date.Equals(new DateTime(year, 12, 26));
            if (isHoliday)          //error(isHoliday && date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                workdays--;
            }
        }
        Console.WriteLine("In the period between {0} and {1} has {2} workdays", today, endDate, workdays);
    }
}