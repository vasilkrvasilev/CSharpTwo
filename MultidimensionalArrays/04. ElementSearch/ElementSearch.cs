using System;

class ElementSearch
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of elements");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];
        int targerIndex = 0;

        Console.WriteLine("Enter the elements in the array");
        for (int position = 0; position < elements; position++)
        {
            array[position] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        int index = Array.BinarySearch(array, number);
        if (index >= 0)                                         //There is such element in the array
        {
            targerIndex = index;
        }
        else                                                    //There is no such element in the array
        {
            targerIndex = ~(index) - 1;
        }

        if (targerIndex >= 0 && index >= 0)
        {
            Console.WriteLine("The element with value {0} is on {1} position in the array", number, targerIndex);
        }
        else if (targerIndex >= 0 && index < 0)
        {
            Console.WriteLine("The array does not consist element with value {0}", number);
            Console.WriteLine("The element with max value but smaller than {0} is on {1} position in the array", number, targerIndex);
        }
        else
        {
            Console.WriteLine("All elements in the array are bigger than {0}", number);
        }
    }
}