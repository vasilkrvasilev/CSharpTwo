using System;
using System.Collections.Generic;

class IncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements in the array");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];
        List<int> subset = new List<int>();
        List<int> maxSubset = new List<int>();

        Console.WriteLine("Enter elements of the array");
        for (int position = 0; position < elements; position++)
        {
            array[position] = int.Parse(Console.ReadLine());
        }
        int maxSubsets = (int)Math.Pow(2, elements) - 1;
        int length = 0;
        int maxLength = 0;
        bool increasing = true;

        for (int currentSubset = 1; currentSubset <= maxSubsets; currentSubset++)     //Create all possible subsets
        {
            for (int bitPosition = 0; bitPosition < elements; bitPosition++)          //Calculate the sum of every subset
            {
                if (((currentSubset >> bitPosition) & 1) == 1)                        //If the bit is 1 the number is part of the subset
                {
                    subset.Add(array[bitPosition]);
                    length++;
                }
            }
            for (int position = 1; position < subset.Count; position++)               //Check is the subset is increasing
			{
			    if (subset[position] < subset[position - 1])
	            {
		             increasing = false;
	            }
			}
            if ((length > maxLength) && increasing)
	        {
                maxLength = length;
                maxSubset = new List<int>(subset);
	        }
            length = 0;
            subset.Clear();
            increasing = true;
        }

        Console.WriteLine("The elements of the increasing subset with max length are:");
        for (int position = 0; position < maxSubset.Count; position++)
        {
            Console.Write("{0} ", maxSubset[position]);
        }
    }
}