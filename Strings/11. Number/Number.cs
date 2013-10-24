using System;
using System.Text;

class Number
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Number as decimal:\r\n{0,15}", number);
        Console.WriteLine("Number as hexadecimal:\r\n{0,15:X}", number);
        Console.WriteLine("Number as percentige:\r\n{0,15:P}", number);
        Console.WriteLine("Number in scientific notation:\r\n{0,15:E}", number);
    }
}