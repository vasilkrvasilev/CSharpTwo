using System;

class Factorial
{
    static byte[] CalculateFactorial(byte[] multiplier, byte[] currentFactorial, byte[] factorial)
    {
        byte tens = 0;
        for (int count = 0; count < multiplier.Length; count++)       ////Multiply each multiplier digit by each current factotial digit
        {
            if (multiplier[count] != 0)
            {
                for (int position = 0; position < currentFactorial.Length - count - 1; position++)
                {
                    byte product = (byte)((multiplier[count] * currentFactorial[position]) + tens);
                    factorial[count + position] = (byte)(product % 10); ////Write the ones of the reselt in the factorial
                    tens = (byte)(product / 10);                        ////Calculate the tens (in mind)
                }

                Array.Copy(factorial, currentFactorial, factorial.Length);
            }
        }

        return factorial;
    }

    static void Print(byte[] factorial, int number)
    {
        string output = string.Empty;
        Console.WriteLine("{0}! is equal to:", number);
        for (int currentDigit = factorial.Length - 1; currentDigit >= 0; currentDigit--)
        {
            output += factorial[currentDigit];
        }

        Console.WriteLine(output);
    }

    static void Main()
    {
        int number = 100;
        byte[] factorial = new byte[160];
        byte[] currentFactorial = new byte[160];
        currentFactorial[0] = 1;
        byte[] multiplier = new byte[3];

        for (int currentNumber = 1; currentNumber <= number; currentNumber++)
        {
            int currentMultiplier = currentNumber;                            ////Present current multiplier as an array of its digits
            for (int count = 0; count < multiplier.Length; count++)
            {
                multiplier[count] = (byte)(currentMultiplier % 10);
                currentMultiplier /= 10;
            }

            factorial = CalculateFactorial(multiplier, currentFactorial, factorial);
            Array.Copy(factorial, currentFactorial, factorial.Length);

            Print(factorial, currentNumber);
        }
    }
}