using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter number in binary numerical system");
        string bynaryNumber = Console.ReadLine();
        int decimalNumber = Convert.ToInt32(bynaryNumber, 2);
        Console.WriteLine("{0} in decimal numerical system is equal to {1}", bynaryNumber, decimalNumber);

        ////By Horner from the book
        int digits = bynaryNumber.Length;
        int number = bynaryNumber[0] - '0';
        for (int iteration = 1; iteration < digits; iteration++)
        {
            number = (number * 2) + bynaryNumber[iteration] - '0';
        }

        Console.WriteLine("{0} in decimal numerical system is equal to {1} (converted by Horner)", bynaryNumber, number);
    }
}