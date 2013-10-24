using System;

class RealNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter real number in decimal numerical system");
        float realNumber = float.Parse(Console.ReadLine());
        byte[] buffer;
        buffer = BitConverter.GetBytes(realNumber);
        string binaryNumber = string.Empty;

        for (int number = buffer.Length - 1; number >= 0; number--)
        {
            string currentBinaryNumber = Convert.ToString(buffer[number], 2).PadLeft(8, '0');
            binaryNumber += currentBinaryNumber;
        }

        string sign = binaryNumber.Substring(0, 1);
        string exponent = binaryNumber.Substring(1, 8);
        string mantissa = binaryNumber.Substring(9, 23);
        Console.WriteLine("{0} in binary numerical system is equal to\n\r\t{1}", realNumber, binaryNumber);
        Console.WriteLine();
        Console.WriteLine("Sing is equal to: {0,18}\n\rexponent to: {1,23}\n\rmantissa to: {2,23}", sign, exponent, mantissa);
    }
}