using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter year");
        int input = int.Parse(Console.ReadLine());
        bool isLeapYear = DateTime.IsLeapYear(input);
        DateTime inputDate = new DateTime(input, 1, 1);
        int timePosition = DateTime.Compare(DateTime.Now, inputDate);

        if (isLeapYear)
        {
            if (timePosition < 0)
            {
                Console.WriteLine("{0} will be a leap year", input);
            }
            else
            {
                Console.WriteLine("{0} was a leap year", input);
            }
        }
        else
        {
            if (timePosition < 0)
            {
                Console.WriteLine("{0} will be not a leap year", input);
            }
            else
            {
                Console.WriteLine("{0} was not a leap year", input);
            }
        }
    }
}