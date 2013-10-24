using System;

class BiggerElement
{
    static bool CompareToNeighbors(int[] array, int position)
    {
        bool isBigger = false;
        if (position >= array.Length || position < 0)
        {
            Console.WriteLine("There is no such element in the array");
            return isBigger;
        }
        else if (position == 0)
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
        Console.WriteLine("Enter position");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of element in the array");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];

        Console.WriteLine("Enter the elements of the array");
        for (int count = 0; count < elements; count++)
        {
            array[count] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Element on position {0} is bigger than its neighbors: {1}", position, CompareToNeighbors(array, position));
    }
}