using System;

class SquareRoot
{
    static double CalculateSquareRoot(string input)
    {
        ulong number = ulong.Parse(input);
        double squareRoot = Math.Sqrt(number);
        return squareRoot;
    }

    static void Main()
    {
        Console.WriteLine("Enter number");
        string input = Console.ReadLine();
        try
        {
            ulong number = ulong.Parse(input);
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("Square Root of {0} is equal to {1}", number, squareRoot);
        }
        catch (FormatException fe)
        {
            Console.WriteLine("You enter invalid number");
            Console.WriteLine(fe.Message);
            Console.WriteLine("You should enter a non negative integer number less than 18446744073709551615.");
            Console.WriteLine("Please try again!");
        }
        catch (OverflowException ofe)
        {
            Console.WriteLine("You enter very big number");
            Console.WriteLine(ofe.Message);
            Console.WriteLine("You should enter a non negative integer number less than 18446744073709551615.");
            Console.WriteLine("Please try again!");
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine("You enter null");
            Console.WriteLine(ane.Message);
            Console.WriteLine("You should enter a non negative integer number less than 18446744073709551615.");
            Console.WriteLine("Please try again!");
        }
        catch (StackOverflowException sofe)
        {
            Console.WriteLine("Unexpected error occur.");
            Console.WriteLine(sofe.Message);
            Console.WriteLine("Please restart the program and try again.");
        }
        finally
        {
            Console.WriteLine();
            Console.WriteLine("Good bye!");
        }
    }
}