using System;

class MaxNumber
{
    static int GetMax(int numberOne, int numberTwo)
    {
        int maxNumber = numberOne;
        if (numberTwo > numberOne)
        {
            maxNumber = numberTwo;
        }

        return maxNumber;
    }

    static void Main()
    {
        int elements = 3;
        int[] array = new int[elements];
        Console.WriteLine("Enter {0} number", elements);
        for (int position = 0; position < elements; position++)
        {
            array[position] = int.Parse(Console.ReadLine());
        }

        int biggestNumber = 0;
        for (int count = 0; count < elements - 1; count++)
        {
            biggestNumber = GetMax(array[count], array[count + 1]);
            array[count + 1] = biggestNumber;
        }

        Console.WriteLine("The max number is {0}", biggestNumber);
    }
}