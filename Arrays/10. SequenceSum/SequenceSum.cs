using System;

class SequenceSum
{
    static void Main()
    {
        Console.WriteLine("Enter subset sum");
        int sum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of elements of the array");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];
        bool noSubset = true;
        int currentSum = 0;

        Console.WriteLine("Enter the elements of the array");
        for (int count = 0; count < elements; count++)
        {
            array[count] = int.Parse(Console.ReadLine());
        }

        for (int members = 1; members <= elements; members++)              //Calculate consecutively the sum of all possible sequences
        {
            for (int position = 0; position <= elements - members; position++)
            {
                for (int number = 0; number < members; number++)
                {
                    currentSum += array[position + number];
                }
                if (currentSum == sum)                                     //Check if the sum is correct
                {
                    noSubset = false;
                    Console.WriteLine("This subset has sum equal to {0}:", sum);
                    for (int number = 0; number < members; number++)
                    {
                        Console.Write("{0} ", array[position + number]);
                    }
                    Console.WriteLine();
                }
                currentSum = 0;
            }
        }

        if (noSubset)
        {
            Console.WriteLine("There is no subset with sum equal to {0}", sum);
        }
    }
}