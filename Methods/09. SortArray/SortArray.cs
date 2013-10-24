using System;

class SortArray
{
    static int[] CreateArray(int elements)
    {
        int[] array = new int[elements];
        Console.WriteLine("Enter elements of the array");
        for (int position = 0; position < elements; position++)
        {
            array[position] = byte.Parse(Console.ReadLine());
        }

        return array;
    }

    static int FindMax(int[] array, int start, int length)
    {
        int maxNumber = int.MinValue;
        int maxPosition = 0;
        for (int position = start; position < start + length; position++)
        {
            if (array[position] > maxNumber)
            {
                maxNumber = array[position];
                maxPosition = position;
            }
        }

        array[maxPosition] = int.MinValue;
        return maxNumber;
    }

    static void Print(int[] array)
    {
        for (int position = 0; position < array.Length; position++)
        {
            Console.Write("{0} ", array[position]);
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements in the array");
        int elements = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter start position");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter length of the sub array");
        int length = int.Parse(Console.ReadLine());

        while (start + length >= elements)
        {
            if (start >= elements)
            {
                Console.WriteLine("You enter invalid start position!\n\rPlease try again!");
                start = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You enter very big length!\n\rPlease try again!");
            length = int.Parse(Console.ReadLine());
        }

        int[] array = CreateArray(elements);
        int[] increasingArray = new int[length];
        int[] decreasingArray = new int[length];

        for (int count = 0; count < length; count++)
        {
            int max = FindMax(array, start, length);
            increasingArray[length - 1 - count] = max;
            decreasingArray[count] = max;
        }

        Console.WriteLine("The elements of the sorted sub array in increasing order are:");
        Print(increasingArray);
        Console.WriteLine("The elements of the sorted sub array in decreasing order are:");
        Print(decreasingArray);
    }
}