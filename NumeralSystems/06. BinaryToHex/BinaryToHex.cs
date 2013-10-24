using System;

class BinaryToHex
{
    static void Main()
    {
        Console.WriteLine("Enter number in binary numerical system");
        string binaryNumber = Console.ReadLine();
        string hexNumber = string.Empty;
        int length = binaryNumber.Length;

        if (length % 4 == 3)
        {
            binaryNumber = "0" + binaryNumber;
            length++;
        }
        else if (length % 4 == 2)
        {
            binaryNumber = "00" + binaryNumber;
            length += 2;
        }
        else if (length % 4 == 1)
        {
            binaryNumber = "000" + binaryNumber;
            length += 3;
        }

        for (int digit = 1; digit <= length / 4; digit++)
        {
            string currentDigit = binaryNumber.Substring(length - (digit * 4), 4);
            switch (currentDigit)
            {
                case "0000":
                    hexNumber = "0" + hexNumber;
                    break;
                case "0001":
                    hexNumber = "1" + hexNumber;
                    break;
                case "0010":
                    hexNumber = "2" + hexNumber;
                    break;
                case "0011":
                    hexNumber = "3" + hexNumber;
                    break;
                case "0100":
                    hexNumber = "4" + hexNumber;
                    break;
                case "0101":
                    hexNumber = "5" + hexNumber;
                    break;
                case "0110":
                    hexNumber = "6" + hexNumber;
                    break;
                case "0111":
                    hexNumber = "7" + hexNumber;
                    break;
                case "1000":
                    hexNumber = "8" + hexNumber;
                    break;
                case "1001":
                    hexNumber = "9" + hexNumber;
                    break;
                case "1010":
                    hexNumber = "A" + hexNumber;
                    break;
                case "1011":
                    hexNumber = "B" + hexNumber;
                    break;
                case "1100":
                    hexNumber = "C" + hexNumber;
                    break;
                case "1101":
                    hexNumber = "D" + hexNumber;
                    break;
                case "1110":
                    hexNumber = "E" + hexNumber;
                    break;
                case "1111":
                    hexNumber = "F" + hexNumber;
                    break;
            }
        }

        Console.WriteLine("{0} in hexademical numerical system is equal to {1}", hexNumber, binaryNumber);
    }
}