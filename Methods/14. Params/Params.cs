using System;

class Params
{
    static int FindMax(params int[] array)
    {
        int max = int.MinValue;
        foreach (int number in array)
        {
            if (number > max)
            {
                max = number;
            }
        }

        return max;
    }

    static int FindMin(params int[] array)
    {
        int min = int.MaxValue;
        foreach (int number in array)
        {
            if (number < min)
            {
                min = number;
            }
        }

        return min;
    }

    static double CalculateAverage(params int[] array)
    {
        double average = 0;
        for (int position = 0; position < array.Length; position++)
        {
            average += array[position];
        }

        average /= array.Length;
        return average;
    }

    static double CalculateSum(params int[] array)
    {
        double sum = 0;
        for (int position = 0; position < array.Length; position++)
        {
            sum += array[position];
        }

        return sum;
    }

    static long CalculateProduct(params int[] array)
    {
        long product = 1;
        for (int position = 0; position < array.Length; position++)
        {
            product *= array[position];
        }

        return product;
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];

        Console.WriteLine("Enter the elements");
        for (int position = 0; position < elements; position++)
        {
            array[position] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Max element has value {0}", FindMax(array));

        Console.WriteLine("Min element has value {0}", FindMin(array));

        Console.WriteLine("The average of all elements is {0}", CalculateAverage(array));

        Console.WriteLine("The sum of all elements is {0}", CalculateSum(array));

        Console.WriteLine("The product of all elements is {0}", CalculateProduct(array));
    }
}