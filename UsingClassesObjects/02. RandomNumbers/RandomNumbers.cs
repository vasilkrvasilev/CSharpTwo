using System;

class RandomNumbers
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int downLimit = 100;
        int upperLimit = 201;
        int elements = 10;

        Console.WriteLine("This is a sequence of random numbers");
        for (int count = 0; count < elements; count++)
        {
            int randomNumber = randomGenerator.Next(downLimit, upperLimit);
            //Second way
            //int randomNumber = randomGenerator.Next(downLimit + count, upperLimit);
            Console.Write("{0} ", randomNumber);
        }
    }
}