using System;

class DecimalToHex
{
    static void Main()
    {
        Console.WriteLine("Enter number in decimal numerical system");
        int decimalNumber = int.Parse(Console.ReadLine());
        string hexNumber = Convert.ToString(decimalNumber, 16);
        Console.WriteLine("{0} in hexademical numerical system is equal to {1}", decimalNumber, hexNumber);
    }
}