using System;

class Permutation
{
    static int numberLoops;
    static int[] loops;
    static bool permutation = true;

    static void NestedLoops(int currentLoop)                    //Generate all possible combination of numbers in the interval [1, n]
    {
        if (currentLoop == numberLoops)
        {
            PrintLoop();
            return;
        }

        for (int count = 1; count <= numberLoops; count++)
        {
            loops[currentLoop] = count;
            NestedLoops(currentLoop + 1);
        }
    }

    static void PrintLoop()                                      //Check which combination is permutation
    {
        for (int number = 0; number < numberLoops; number++)
        {
            for (int position = number + 1; position < numberLoops; position++)
            {
                if (loops[number] == loops[position])
                {
                    permutation = false;
                }
            }
        }
        if (permutation)
        {
            for (int position = 0; position < numberLoops; position++)
            {
                Console.Write("{0} ", loops[position]);
            }
            Console.WriteLine();
        }
        permutation = true;
    }

    static void Main()
    {
        Console.WriteLine("Enter number");
        numberLoops = int.Parse(Console.ReadLine());
        loops = new int[numberLoops];
        Console.WriteLine("All permutations of numbers between 1 and {0} are:", numberLoops);
        NestedLoops(0);
    }
}