using System;

class QuickSort
{
    static void QuickSort(int[] array, int down, int up)
    {
        int downLimit = down;
        int upperLimit = up;
        int pivot = array[(down + up) / 2];
        while (downLimit <= upperLimit)
        {
            while (array[downLimit] < pivot)
            {
                downLimit++;
            }

            while (array[upperLimit] > pivot)
            {
                upperLimit--;
            }

            if (downLimit <= upperLimit)
            {
                int exchangeValue = array[downLimit];
                array[downLimit] = array[upperLimit];
                array[upperLimit] = exchangeValue;
                downLimit++;
                upperLimit--;
            }
        }

        if (down < upperLimit)
        {
            QuickSort(array, down, upperLimit);
        }

        if (downLimit < up)
        {
            QuickSort(array, downLimit, up);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements of the array (more then 3)");
        int elements = int.Parse(Console.ReadLine());
        
        int[] oldArray = new int[elements];
        int[] newArray = new int[elements];

        Console.WriteLine("Enter the elements of the array");
        for (int count = 0; count < elements; count++)
        {
            oldArray[count] = int.Parse(Console.ReadLine());
        }
        Array.Copy(oldArray, newArray, elements);

        int[] pivots = new int[elements];
        for (int count = 0; count < elements; count++)
        {
            pivots[count] = count + 1;
        }

        int countPivots = 0;                            //Current number pivots
        int currentPivot = pivots[0];                   //Value of current pivot
        int numberPivot = oldArray[currentPivot - 1];   //Number in the array at the pivot position
        int newPosition = 0;                            //Position to put the next sorted number
        int currentNumber = int.MinValue;               //Value of the current number to be sorted
        int previosPivot = 0;                           //Position of the previos pivot
        int nextPivot = elements;                       //Position of the next pivot
        while (countPivots < elements)
        {
            if (nextPivot != elements)
            {
                previosPivot = nextPivot;
            }
            else
            {
                previosPivot = 0;
            }
            for (int position = previosPivot + 1; position < elements; position++)
            {
                if (pivots[position] == 0)
                {
                    nextPivot = position;
                    break;
                }
                if (position == elements - 1)
                {
                    nextPivot = elements;
                }
            }
            newPosition = previosPivot;
            currentNumber = int.MinValue;
            if (nextPivot - previosPivot > 2)
            {
                if (previosPivot == 0 && pivots[previosPivot] != 0)
                {
                    currentPivot = pivots[previosPivot];
                }
                else
                {
                    currentPivot = pivots[previosPivot + 1];
                }
            }
            else if (nextPivot - previosPivot == 2)
            {
                pivots[previosPivot + 1] = 0;
                countPivots++;
                continue;
            }
            else
            {
                if (previosPivot == 0 && pivots[previosPivot] != 0)
                {
                    pivots[previosPivot] = 0;
                    countPivots++;
                    continue;
                }
                else
                {
                    if (previosPivot == nextPivot)
                    {
                        nextPivot = elements;
                    }
                    continue;
                }
            }

            numberPivot = newArray[currentPivot - 1];

            for (int position = previosPivot; position < nextPivot; position++)
            {
                currentNumber = oldArray[position];
                if (currentNumber < numberPivot)
                {
                    newArray[newPosition] = currentNumber;
                    newPosition++;
                }
            }
            pivots[newPosition] = 0;
            newArray[newPosition] = numberPivot;
            newPosition++;
            for (int position = previosPivot; position < nextPivot; position++)
            {
                currentNumber = oldArray[position];
                if (currentNumber > numberPivot)
                {
                    newArray[newPosition] = currentNumber;
                    newPosition++;
                }
            }
            countPivots++;
            Array.Copy(newArray, oldArray, elements);
        }

        Console.WriteLine("The elements of the sorted array are:");
        for (int count = 0; count < elements; count++)
        {
            Console.Write("{0} ", newArray[count]);
        }
    }
}