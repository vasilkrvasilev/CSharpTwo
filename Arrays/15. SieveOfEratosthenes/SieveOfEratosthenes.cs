using System;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    static void Main()
    {
        int upperLimit = 100;
        bool[] allNumbers = new bool[upperLimit + 1];                         //Use bool array to present numbers in the interval [0, n]
        allNumbers[0] = true;
        allNumbers[1] = true;
        int maxDivider = (int)Math.Sqrt(upperLimit);
        int divider = 2;
        while (divider <= maxDivider)
        {
            for (int number = divider + 1; number <= upperLimit; number++)    //Remove those, which are not prime
            {
                if (number % divider == 0)
                {
                    allNumbers[number] = true;
                }
            }
            divider++;
        }

        Console.WriteLine("All prime numbers from 0 to {0} are:", upperLimit);
        for (int position = 0; position < allNumbers.Length; position++)
        {
            if (!allNumbers[position])
            {
                Console.Write("{0} ", position);
            }
        }
    }
}