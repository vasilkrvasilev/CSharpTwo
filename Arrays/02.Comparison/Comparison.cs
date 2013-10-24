using System;

class Comparison
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements of the arrays");
        int elements = int.Parse(Console.ReadLine());
        int[] firstArray = new int[elements];
        int[] secondArray = new int[elements];

        Console.WriteLine("Enter the elements of the first array");
        for (int count = 0; count < elements; count++)
        {
            firstArray[count] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the elements of the second array");
        for (int count = 0; count < elements; count++)
        {
            secondArray[count] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        for (int count = 0; count < elements; count++)
        {
            if (firstArray[count] < secondArray[count])
            {
                Console.WriteLine("First array < Second array");
                areEqual = false;
                break;
            }
            if (firstArray[count] > secondArray[count])
            {
                Console.WriteLine("First array > Second array");
                areEqual = false;
                break;
            }
        }

        if (areEqual)
        {
            Console.WriteLine("First array is equal to the Second array");
        }
    }
}