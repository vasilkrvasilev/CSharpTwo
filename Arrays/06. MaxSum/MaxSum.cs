using System;
using System.Collections.Generic;

class MaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements of the array");
        int elements = int.Parse(Console.ReadLine());
        int arrayElements = elements;

        //First way by using List<int>
        Console.WriteLine("Enter number of elements of the subset");
        int subset = int.Parse(Console.ReadLine());
        List<int> arrayOne = new List<int>();
        int sum = 0;

        Console.WriteLine("Enter the elements of the array");
        for (int count = 0; count < elements; count++)
        {
            arrayOne.Add(int.Parse(Console.ReadLine()));
        }
        int maxNumber = int.MinValue;

        Console.WriteLine("The elements of the subset are:");
        for (int number = 0; number < subset; number++)                  //Find the max elements and add them to the subset
        {
            for (int position = 0; position < elements; position++)
            {
                if (arrayOne[position] > maxNumber)
                {
                    maxNumber = arrayOne[position];
                }
            }
            Console.Write("{0} ", maxNumber);
            sum += maxNumber;
            arrayOne.Remove(maxNumber);
            maxNumber = int.MinValue;
            elements--;
        }
        Console.WriteLine();
        Console.WriteLine("The sum of the subset is {0}", sum);

        //Second way by using int[]
        int[] arrayTwo = new int[arrayElements];
        int subsetSum = 0;
        Console.WriteLine("Enter the elements of the array");
        for (int count = 0; count < arrayElements; count++)
        {
            arrayTwo[count] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrayTwo);

        Console.WriteLine("The elements of the subset are:");
        for (int count = arrayElements - 1; count > arrayElements - 1 - subset; count--)
        {
            Console.Write("{0} ", arrayTwo[count]);
            subsetSum += arrayTwo[count];
        }
        Console.WriteLine();
        Console.WriteLine("The sum of the subset is {0}", subsetSum);
    }
}