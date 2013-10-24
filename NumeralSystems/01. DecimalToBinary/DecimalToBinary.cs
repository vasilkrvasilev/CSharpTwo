using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter number in decimal numerical system");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binaryNumber = Convert.ToString(decimalNumber, 2).PadLeft(32, '0');
        Console.WriteLine("{0} in binary numerical system is equal to {1}", decimalNumber, binaryNumber);
    }
}