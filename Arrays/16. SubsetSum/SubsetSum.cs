using System;
using System.Collections.Generic;

class SubsetSum
{
    static void Main()
    {
        Console.WriteLine("Enter sum of subset");
        long sum = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of elements in the array");
        int members = int.Parse(Console.ReadLine());
        long[] numbers = new long[members];

        Console.WriteLine("Enter the elements of the array");
        for (int posiiton = 0; posiiton < members; posiiton++)
        {
            numbers[posiiton] = long.Parse(Console.ReadLine());
        }

        List<long> subsetMembers = new List<long>();
        int subsets = 0;
        int maxSubsets = (int)Math.Pow(2, members) - 1;
        for (int currentSubset = 1; currentSubset <= maxSubsets; currentSubset++)       //Create all possible subsets
        {
            long currentSum = 0;
            for (int bitPosition = 0; bitPosition < members; bitPosition++)             //Calculate the sum of every subset
            {
                if (((currentSubset >> bitPosition) & 1) == 1)                          //If the bit is 1 the number is part of the subset
                {
                    currentSum += numbers[bitPosition];
                    subsetMembers.Add(numbers[bitPosition]);
                }
            }
            if (currentSum == sum)                                                      //Check is the sum correct
            {
                subsets++;
                Console.WriteLine("Elements of the subset with sum equal to {0} are:", sum);
                for (int position = 0; position < subsetMembers.Count; position++)
                {
                    Console.Write("{0} ", subsetMembers[position]);
                }
                Console.WriteLine();
            }
            subsetMembers.Clear();
        }

        Console.WriteLine("There are {0} subsets with sum equal to {1}", subsets, sum);
    }
}