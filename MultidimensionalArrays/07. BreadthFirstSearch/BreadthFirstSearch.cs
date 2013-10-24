using System;
using System.Collections.Generic;

class BreadthFirstSearch
{
    static void Main()
    {
        Console.WriteLine("Enter number rows");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number columns");
        int columns = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, columns];
        Console.WriteLine("Enter elements of the matrix");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                matrix[row, column] = int.Parse(Console.ReadLine());
            }
        }

        int elements = rows * columns;
        int[,] binaryMatrix = new int[rows, columns];
        Queue<int> queue = new Queue<int>();
        int currentElement = 0;
        int currentSequence = 0;
        int maxSequence = 0;
        int sequenceElement = 0;

        for (int currentRow = 0; currentRow < rows; currentRow++)
        {
            for (int currentColumn = 0; currentColumn < columns; currentColumn++)           //Find the sequence for each element
            {
                currentElement = matrix[currentRow, currentColumn];
                queue.Enqueue(currentRow * columns + currentColumn);
                for (int binaryRow = 0; binaryRow < rows; binaryRow++)                      //Return the matrix into a binary -
                {                                                                           //1 current element, 0 other element
                    for (int binaryColumn = 0; binaryColumn < columns; binaryColumn++)
                    {
                        if (currentElement == matrix[binaryRow, binaryColumn])
                        {
                            binaryMatrix[binaryRow, binaryColumn] = 1;
                        }
                        else
                        {
                            binaryMatrix[binaryRow, binaryColumn] = 0;
                        }
                    }
                }
                while (queue.Count > 0)                                                     //By using queue add find and add all 1
                {                                                                           //around the current one
                    int queueElement = queue.Peek();
                    int queueRow = queueElement / columns;
                    int queueColumn = queueElement % columns;
                    if (queueRow > 0 && binaryMatrix[queueRow - 1, queueColumn] == 1)       //If we find 1 we increase the seqence
                    {
                        queue.Enqueue((queueRow - 1) * columns + queueColumn);
                        binaryMatrix[queueRow - 1, queueColumn] = 0;
                        currentSequence++;
                    }
                    if (queueColumn < columns - 1 && binaryMatrix[queueRow, queueColumn + 1] == 1)
                    {
                        queue.Enqueue((queueRow) * columns + queueColumn + 1);
                        binaryMatrix[queueRow, queueColumn + 1] = 0;
                        currentSequence++;
                    }
                    if (queueRow < rows - 1 && binaryMatrix[queueRow + 1, queueColumn] == 1)
                    {
                        queue.Enqueue((queueRow + 1) * columns + queueColumn);
                        binaryMatrix[queueRow + 1, queueColumn] = 0;
                        currentSequence++;
                    }
                    if (queueColumn > 0 && binaryMatrix[queueRow, queueColumn - 1] == 1)
                    {
                        queue.Enqueue((queueRow) * columns + queueColumn - 1);
                        binaryMatrix[queueRow, queueColumn - 1] = 0;
                        currentSequence++;
                    }
                    queue.Dequeue();                                                    //Delete the current one till there it is empty
                }
                if (currentSequence > maxSequence)                                      //Check is the current sequence the max
                {
                    maxSequence = currentSequence;
                    sequenceElement = currentElement;
                }
                currentSequence = 0;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The matrix");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.Write("{0} ", matrix[row, column]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("The max sequence has size {0} elements \"{1}\"", maxSequence, sequenceElement);
    }
}