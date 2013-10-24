using System;

class SelectionSort
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

        int minNumber = int.MaxValue;
        int currentPosition = 0;
        for (int iteration = 1; iteration < elements; iteration++)   //Find the min element and move it to the beginning of the array
        {
            for (int position = iteration - 1; position < elements; position++)
            {
                if (array[position] < minNumber)
                {
                    minNumber = array[position];
                    currentPosition = position;
                }
            }
            int exchangeNumber = array[iteration - 1];
            array[iteration - 1] = array[currentPosition];
            array[currentPosition] = exchangeNumber;
            minNumber = int.MaxValue;
            currentPosition = 0;
        }

        Console.WriteLine("The elements of the sorted array are:");
        for (int count = 0; count < elements; count++)
        {
            Console.Write("{0} ", array[count]);
        }
    }
}