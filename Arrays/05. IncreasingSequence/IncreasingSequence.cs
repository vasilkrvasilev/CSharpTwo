using System;
using System.Collections.Generic;

class IncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements of the array");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];

        Console.WriteLine("Enter the elements of the array");
        for (int count = 0; count < elements; count++)
        {
            array[count] = int.Parse(Console.ReadLine());
        }

        List<int> maxSequence = new List<int>();
        List<int> sequence = new List<int>();
        sequence.Add(array[0]);
        for (int count = 1; count < elements; count++)
        {
            if (array[count] > array[count - 1])
            {
                sequence.Add(array[count]);
            }
            else
            {
                if (sequence.Count > maxSequence.Count)
                {
                    maxSequence.Clear();
                    foreach (var number in sequence)
                    {
                        maxSequence.Add(number);
                    }
                    sequence.Clear();
                    sequence.Add(array[count]);
                }
                else
                {
                    sequence.Clear();
                    sequence.Add(array[count]);
                }
            }
        }

        if (sequence.Count > maxSequence.Count)
        {
            maxSequence.Clear();
            foreach (var number in sequence)
            {
                maxSequence.Add(number);
            }
        }

        Console.WriteLine("The increasing sequence with max length is:");
        for (int count = 0; count < maxSequence.Count; count++)
        {
            Console.Write("{0} ", maxSequence[count]);
        }
    }
}