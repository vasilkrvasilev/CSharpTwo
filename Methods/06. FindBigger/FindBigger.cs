using System;

class FindBigger
{
    static bool CompareToNeighbors(int[] array, int position)
    {
        bool isBigger = false;
        if (position == 0)
        {
            isBigger = (array[position] > array[position + 1]);
            return isBigger;
        }
        else if (position == array.Length - 1)
        {
            isBigger = (array[position] > array[position - 1]);
            return isBigger;
        }
        else
        {
            isBigger = (array[position] > array[position + 1]) && (array[position] > array[position - 1]);
            return isBigger;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number of element in the array");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];

        Console.WriteLine("Enter the elements of the array");
        for (int count = 0; count < elements; count++)
        {
            array[count] = int.Parse(Console.ReadLine());
        }

        for (int position = 0; position < elements; position++)
        {
            bool biggerNumber = CompareToNeighbors(array, position);
            if (biggerNumber)
            {
                Console.WriteLine(position);
                Console.WriteLine("First element, bigger than its neighbors, is on position {0}", position);
                break;
            }

            if (!biggerNumber && position == elements - 1)
            {
                Console.WriteLine(-1);
                Console.WriteLine("There is no element, bigger than its neighbors, in the array");
            }
        }
    }
}