using System;
using System.Collections.Generic;

class MaxFrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements of the array");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];
        List<int> differentElements = new List<int>();
        List<int> frequency = new List<int>();
        bool alone = true;

        Console.WriteLine("Enter the elements of the array");
        for (int count = 0; count < elements; count++)
        {
            array[count] = int.Parse(Console.ReadLine());
        }

        for (int position = 0; position < elements; position++)   //Find all different elements in the array and count their frequency
        {
            for (int number = 0; number < differentElements.Count; number++)
            {
                if (array[position] == differentElements[number])
                {
                    frequency[number]++;
                    alone = false;
                }
            }
            if (alone)
            {
                differentElements.Add(array[position]);
                frequency.Add(1);
            }
            alone = true;
        }

        int currentNumber = 0;
        int maxFrequency = 0;                                    //Find the elements with max frequency
        for (int position = 0; position < differentElements.Count; position++)
        {
            if (frequency[position] > maxFrequency)
            {
                maxFrequency = frequency[position];
                currentNumber = differentElements[position];
            }
        }
        Console.WriteLine("The element with max frequency is {0}\n\rIt is repeated {1} times", currentNumber, maxFrequency);
    }
}