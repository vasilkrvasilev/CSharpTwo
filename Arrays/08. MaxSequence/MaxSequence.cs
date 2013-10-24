using System;
using System.Collections.Generic;

class MaxSequence
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements of the array");
        int elements = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of elements of the subset");
        int subset;
        bool isSubset = false;

        do
        {
            bool isNumber = int.TryParse(Console.ReadLine(), out subset);
            if (isNumber && subset < elements && subset > 0)
            {
                isSubset = true;
            }
        }
        while (!isSubset);
        List<int> array = new List<int>();
        int sum = 0;

        Console.WriteLine("Enter the elements of the array");
        for (int count = 0; count < elements; count++)
        {
            array.Add(int.Parse(Console.ReadLine()));
        }

        for (int count = 0; count < subset; count++)                    //Create first sequence
        {
            sum += array[count];
        }
        int maxSum = sum;
        int sequencePosition = subset - 1;

        for (int position = subset; position < elements; position++)   //Check consecutively all possible sequences and find the max
        {
            sum += (array[position] - array[position - subset]);
            if (sum > maxSum)
            {
                maxSum = sum;
                sequencePosition = position;
            }
        }

        Console.WriteLine("The elements of the subset with max sum are:");
        for (int count = subset - 1; count >= 0; count--)
        {
            Console.Write("{0} ", array[sequencePosition - count]);
        }
        Console.WriteLine();
        Console.WriteLine("Their sum is: {0}", maxSum);
    }
}