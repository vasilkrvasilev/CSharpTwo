using System;

class Interval
{
    static string[] EnterNumbers(byte elements)
    {
        Console.WriteLine("Enter {0} increasing numbers", elements);
        string[] input = new string[elements];
        for (int count = 0; count < elements; count++)
        {
            input[count] = Console.ReadLine();
        }
        return input;
    }

    static byte ReadNumber(byte start, byte end, int count, string[] input)
    {
        byte number = byte.Parse(input[count]);
        if (number < start)
        {
            throw new ApplicationException ("You enter very small number");
        }
        else if (number > end)
        {
            throw new ApplicationException ("You enter very big number");
        }

        return number;
    }

    static void Main()
    {
        byte elements = 3;

        string[] input = EnterNumbers(elements);

        byte start = 1;
        byte end = 100;
        int count = 0;

        try
        {
            for (count = 0; count < elements; count++)
            {
                byte number = ReadNumber(start, end, count, input);
                start = number;
            }
        }
        catch (ApplicationException ae)
        {
            Console.WriteLine("You enter invalid number on {0} position", count);
            Console.WriteLine(ae.Message);
            Console.WriteLine("You should enter a positive integer number in the interval ({0}, {1})", start, end);
            Console.WriteLine("Please try again!");
        }
        catch (FormatException fe)
        {
            Console.WriteLine("You enter invalid number on {0} position", count);
            Console.WriteLine(fe.Message);
            Console.WriteLine("You should enter a positive integer number in the interval ({0}, {1})", start, end);
            Console.WriteLine("Please try again!");
        }
        catch (OverflowException ofe)
        {
            Console.WriteLine("You enter very big number");
            Console.WriteLine(ofe.Message);
            Console.WriteLine("You should enter a positive integer number in the interval ({0}, {1})", start, end);
            Console.WriteLine("Please try again!");
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine("You enter null");
            Console.WriteLine(ane.Message);
            Console.WriteLine("You should enter a positive integer number in the interval ({0}, {1})", start, end);
            Console.WriteLine("Please try again!");
        }
        catch (StackOverflowException sofe)
        {
            Console.WriteLine("Unexpected error occur.");
            Console.WriteLine(sofe.Message);
            Console.WriteLine("Please restart the program and try again.");
        }
    }
}