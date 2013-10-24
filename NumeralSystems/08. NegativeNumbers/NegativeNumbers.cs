using System;

class NegativeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number in decimal numerical system");
        short decimalNumber = short.Parse(Console.ReadLine());
        string binaryNumber = Convert.ToString(decimalNumber, 2).PadLeft(16, '0');
        Console.WriteLine(
            "{0} in binary numerical system is equal to {1} {2}", 
            decimalNumber, 
            binaryNumber.Substring(0, 8), 
            binaryNumber.Substring(8, 8));
        Console.WriteLine();
        Console.WriteLine(
            "Sing is equal to: {0}\tand the number to: {1}", 
            binaryNumber.Substring(0, 1), 
            binaryNumber.Substring(1, 15));
    }
}