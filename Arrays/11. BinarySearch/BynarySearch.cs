using System;

class BynarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of elements in the array");
        int elements = int.Parse(Console.ReadLine());
        int[] array = new int[elements];

        Console.WriteLine("Enter the elements of the array");
        for (int count = 0; count < elements; count++)
        {
            array[count] = int.Parse(Console.ReadLine());
        }

        //Second way
        //The array could be filled with random numbers
        //Random randomGenerator = new Random();
        //int upperLimit = int.Parse(Console.ReadLine());
        //for (int position = 0; position < elements; position++)
        //{
        //    array[position] = randomGenerator.Next(position, upperLimit);
        //}

        Array.Sort(array);
        bool noNumber = true;
        int firstElement = 0;                   //First element in the area we search
        int endElement = elements - 1;          //Last element in the area we search
        int middleElement = elements / 2;       //Middle element in the area we search

        while (elements > 0)
        {
            if (number == array[middleElement])
            {
                Console.WriteLine("{0} is on {1} position in the sorted array (from 0)", number, middleElement);
                noNumber = false;
                break;
            }
            else if (number < array[middleElement])
            {
                if (firstElement != middleElement)
                {
                    endElement = middleElement - 1;
                    elements = middleElement - firstElement;
                    middleElement = firstElement + elements / 2;
                }
                else
                {
                    elements = 0;
                }
            }
            else
            {
                if (firstElement != middleElement)
                {
                    firstElement = middleElement + 1;
                    elements = endElement - middleElement;
                    middleElement = firstElement + elements / 2;
                }
                else
                {
                    elements = 0;
                }
            }
        }

        if (noNumber)
        {
            Console.WriteLine("There is no {0} in the array", number);
        }
    }
}