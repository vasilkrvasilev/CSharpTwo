using System;

class MergeSort
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements of the array");
	    int elements = int.Parse(Console.ReadLine());
	    int[] oldArray = new int[elements];
	    int[] newArray = new int[elements];

	    Console.WriteLine("Enter the elements of the array");
	    for (int count = 0; count < elements; count++)
	    {
		    oldArray[count] = int.Parse(Console.ReadLine());
	    }

        //Second way
        //The array could be filled with random numbers
        //Random randomGenerator = new Random();
        //int upperLimit = int.Parse(Console.ReadLine());
        //for (int count = 0; count < elements; count++)
        //{
        //    oldArray[count] = randomGenerator.Next(count, upperLimit);
        //}

	    int mergeStep = 1;                          //Current merge step
	    int numberArrays = elements;                //Current number sub arrays
	    int stepOne = 0;                            //Number of ordered elements from the first sub array
        int stepTwo = 0;                            //Number of ordered elements from the second sub array
	    bool noReminder = true;                     //Are all sub array equal to the merge step
	    bool oddArrays = false;                     //Is number of sub arrays odd
	    bool part = false;                          //Is a sub array smaller than the merge step
	    int lastStep = 0;                           //Size of the last sub array
        int partStep = 0;                           //How smaller is the last sub array than the merge step
        while (numberArrays > 1)
        {
            if (numberArrays % 2 != 0)
            {
                oddArrays = true;
                numberArrays -= 1;
            }
            else
            {
                oddArrays = false;
            }
            for (int currentArray = 0; currentArray < numberArrays; currentArray += 2)
            {
                while (stepOne < mergeStep && stepTwo < mergeStep - partStep)
                {
                    int currentStepOne = currentArray * mergeStep + stepOne;
                    int currentStepTwo = (currentArray + 1) * mergeStep + stepTwo;
                    int newCurrentStep = currentArray * mergeStep + stepOne + stepTwo;
                    if (oldArray[currentStepOne] <= oldArray[currentStepTwo])
                    {
                        newArray[newCurrentStep] = oldArray[currentStepOne];
                        stepOne++;
                    }
                    else
                    {
                        newArray[newCurrentStep] = oldArray[currentStepTwo];
                        stepTwo++;
                    }
                    if (stepOne == mergeStep)
                    {
                        for (int number = stepTwo; number < mergeStep - partStep; number++)
                        {
                            newArray[(currentArray + 1) * mergeStep + number] = oldArray[(currentArray + 1) * mergeStep + number];
                        }
                    }
                    if (stepTwo == mergeStep - partStep)
                    {
                        for (int number = stepOne; number < mergeStep; number++)
                        {
                            newArray[(currentArray + 1) * mergeStep - partStep + number] = 
                                oldArray[currentArray * mergeStep + number];
                        }
                    }
                }
                if (part && (currentArray == numberArrays - 2))
                {
                    partStep = mergeStep - (elements % mergeStep);
                }
                stepOne = 0;
                stepTwo = 0;
            }
            if (oddArrays)
            {
                if (part)
                {
                    lastStep = elements % mergeStep;
                }
                else
                {
                    lastStep = mergeStep;
                }
                for (int number = 0; number < lastStep; number++)
                {
                    newArray[numberArrays * mergeStep + number] = oldArray[numberArrays * mergeStep + number];
                }
            }
            Array.Copy(newArray ,oldArray, elements);
            newArray = new int[elements];
            mergeStep *= 2;
            partStep = 0;
            if ((elements % mergeStep) != 0)
            {
                noReminder = false;
            }
            if (noReminder)
            {
                numberArrays = elements / mergeStep;
            }
            else
            {
                numberArrays = elements / mergeStep + 1;
                part = true;
                if (numberArrays == 2)
                {
                    partStep = mergeStep - (elements % mergeStep);
                } 
            }
            noReminder = true;
            stepOne = 0;
            stepTwo = 0;
        }

        Console.WriteLine("The elements of the sorted array are:");
        for (int count = 0; count < elements; count++)
        {
            Console.Write("{0} ", oldArray[count]);
        }
	}
}