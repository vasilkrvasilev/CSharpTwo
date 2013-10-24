using System;

class HexToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter number in hexademical numerical system");
        string hexNumber = Console.ReadLine();
        string binaryNumber = string.Empty;
        int length = hexNumber.Length;

        for (int digit = 0; digit < length; digit++)
        {
            switch (hexNumber[digit])
            {
                case '0':
                    binaryNumber += "0000";
                    break;
                case '1':
                    binaryNumber += "0001";
                    break;
                case '2':
                    binaryNumber += "0010";
                    break;
                case '3':
                    binaryNumber += "0011";
                    break;
                case '4':
                    binaryNumber += "0100";
                    break;
                case '5':
                    binaryNumber += "0101";
                    break;
                case '6':
                    binaryNumber += "0110";
                    break;
                case '7':
                    binaryNumber += "0111";
                    break;
                case '8':
                    binaryNumber += "1000";
                    break;
                case '9':
                    binaryNumber += "1001";
                    break;
                case 'A':
                    binaryNumber += "1010";
                    break;
                case 'B':
                    binaryNumber += "1011";
                    break;
                case 'C':
                    binaryNumber += "1100";
                    break;
                case 'D':
                    binaryNumber += "1101";
                    break;
                case 'E':
                    binaryNumber += "1110";
                    break;
                case 'F':
                    binaryNumber += "1111";
                    break;
            }
        }

        Console.WriteLine("{0} in binary numerical system is equal to {1}", binaryNumber, hexNumber);
    }
}