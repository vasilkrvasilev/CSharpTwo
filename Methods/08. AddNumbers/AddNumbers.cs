using System;

class AddNumbers
{
    static byte[] EnterDigits(byte[] array, int digits)
    {
        for (int position = 0; position < digits; position++)
        {
            array[position] = byte.Parse(Console.ReadLine());
        }

        return array;
    }

    static byte AddDigits(int position, byte[] firstArray, byte[] secondArray)
    {
        byte result = (byte)(firstArray[position] + secondArray[position]);
        return result;
    }

    static int CalculateSumDigits(int firstNumberDigits, int secondNumberDigits)
    {
        int sumDigits = firstNumberDigits;
        if (secondNumberDigits > firstNumberDigits)
        {
            sumDigits = secondNumberDigits;
        }

        return sumDigits;
    }

    static void PrintSum(byte[] sum)
    {
        string output = string.Empty;
        Console.WriteLine("Sum of the two numbers is:");
        for (int currentDigit = sum.Length - 1; currentDigit >= 0; currentDigit--)
        {
            output += sum[currentDigit];
        }

        Console.WriteLine(output);
    }

    static void Main()
    {
        Console.WriteLine("Enter number of digits of the first number");
        int firstNumberDigits = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of digits of the second number");
        int secondNumberDigits = int.Parse(Console.ReadLine());

        int sumDigits = CalculateSumDigits(firstNumberDigits, secondNumberDigits);
        byte[] firstNumber = new byte[sumDigits];
        byte[] secondNumber = new byte[sumDigits];
        byte[] sum = new byte[sumDigits + 1];

        Console.WriteLine("Enter the digits of the first number from the last one");
        EnterDigits(firstNumber, firstNumberDigits);

        Console.WriteLine("Enter the digits of the second number from the last one");
        EnterDigits(secondNumber, secondNumberDigits);

        for (int position = 0; position < sumDigits; position++)
        {
            byte digitSum = AddDigits(position, firstNumber, secondNumber);
            sum[position] += (byte)(digitSum % 10);
            sum[position + 1] += (byte)(digitSum / 10);
        }

        PrintSum(sum);
    }
}