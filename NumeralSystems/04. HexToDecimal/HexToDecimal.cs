using System;

class HexToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter number in hexademical numerical system");
        string hexNumber = Console.ReadLine();
        int decimalNumber = Convert.ToInt32(hexNumber, 16);
        Console.WriteLine("{0} in decimal numerical system is equal to {1}", hexNumber, decimalNumber);
    }
}