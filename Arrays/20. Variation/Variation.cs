using System;

class Variation
{
    static int numberLoops;
    static int numberIteration;
    static int[] loops;

    static void NestedLoops(int currentLoop)                    //Generate all possible combination of m numbers in the interval [1, n]
    {
        if (currentLoop == numberLoops)
        {
            PrintLoop();
            return;
        }

        for (int count = 1; count <= numberIteration; count++)
        {
            loops[currentLoop] = count;
            NestedLoops(currentLoop + 1);
        }
    }

    static void PrintLoop()                                      //Check which combination is variation
    {
        for (int position = 0; position < numberLoops; position++)
        {
            Console.Write("{0} ", loops[position]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter number of elements of the variation");
        numberLoops = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number");
        numberIteration = int.Parse(Console.ReadLine());
        loops = new int[numberLoops];
        Console.WriteLine("All variations of {0} numbers between 1 and {1} are:", numberLoops, numberIteration);
        NestedLoops(0);
    }
}