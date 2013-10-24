using System;

class GenericMethods
{
    static dynamic FindMax(dynamic array)
    {
        dynamic max = (dynamic)int.MinValue;
        for (int position = 0; position < array.Length; position++)
        {
            if (array[position] > max)
            {
                max = array[position];
            }
        }

        return max;
    }

    static dynamic FindMin(dynamic array)
    {
        dynamic min = (dynamic)int.MaxValue;
        for (int position = 0; position < array.Length; position++)
        {
            if (array[position] < min)
            {
                min = array[position];
            }
        }

        return min;
    }

    static double CalculateAverage(dynamic array)
    {
        double average = 0;
        for (int position = 0; position < array.Length; position++)
        {
            average += (double)array[position];
        }

        average /= array.Length;
        return average;
    }

    static dynamic CalculateSum(dynamic array)
    {
        dynamic sum = 0;
        for (int position = 0; position < array.Length; position++)
        {
            sum += array[position];
        }

        return sum;
    }

    static dynamic CalculateProduct(dynamic array)
    {
        dynamic product = 1;
        for (int position = 0; position < array.Length; position++)
        {
            product *= array[position];
        }

        return product;
    }

    static dynamic EnterElements(int elements)
    {
        dynamic[] array = new dynamic[elements];
        Console.WriteLine("Enter first element");
        string firstElement = Console.ReadLine();
        long integerNumber;
        double realNumber;
        decimal decimalNumber;
        bool isInteger = long.TryParse(firstElement, out integerNumber);
        bool isReal = double.TryParse(firstElement, out realNumber);
        bool isDecimal = decimal.TryParse(firstElement, out decimalNumber);
        Console.WriteLine("Enter rest elements");
        if (isInteger)
        {
            array[0] = integerNumber;
            for (int position = 1; position < elements; position++)
            {
                array[position] = long.Parse(Console.ReadLine());
            }
        }
        else if (isReal)
        {
            array[0] = realNumber;
            for (int position = 1; position < elements; position++)
            {
                array[position] = double.Parse(Console.ReadLine());
            }
        }
        else if (isDecimal)
        {
            array[0] = decimalNumber;
            for (int position = 1; position < elements; position++)
            {
                array[position] = decimal.Parse(Console.ReadLine());
            }
        }

        return array;
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements");
        int elements = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();

        dynamic[] array = EnterElements(elements);      ////The input should be parsed correctly to execute properly the other methods

        Console.WriteLine("Max element has value {0}", FindMax(array));

        Console.WriteLine("Min element has value {0}", FindMin(array));

        Console.WriteLine("The average of all elements is {0}", CalculateAverage(array));

        Console.WriteLine("The sum of all elements is {0}", CalculateSum(array));

        Console.WriteLine("The product of all elements is {0}", CalculateProduct(array));
    }
}