using System;

class EqualSequence
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

        int sequenceElement = array[0];
        int maxSequence = 0;
        int sequence = 1;
        for (int count = 1; count < elements; count++)          //Divide array to sequences of same elements
        {
            if (array[count] == array[count - 1])
            {
                sequence++;
            }
            else
            {
                if (sequence > maxSequence)                    //Start new sequences and check is the finished one the max
                {
                    maxSequence = sequence;
                    sequenceElement = array[count - 1];
                    sequence = 1;
                }
                else
                {
                    sequence = 1;
                }
            }
        }

        Console.WriteLine("The sequence with max length is:");
        for (int count = 0; count < maxSequence; count++)
        {
            Console.Write("{0} ", sequenceElement);
        }
    }
}