using System;

class SubMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter number of rows of the matrix bigger than 2");
        byte rows = byte.Parse(Console.ReadLine());                            //Small number
        Console.WriteLine("Enter number of columns of the matrix bigger than 2");
        byte columns = byte.Parse(Console.ReadLine());                         //Small number
        int[,] matrix = new int[rows, columns];

        Console.WriteLine("Enter the elements of the matrix");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                matrix[row, column] = int.Parse(Console.ReadLine());
            }
        }

        int sum = 0;
        int maxSum = 0;
        int subset = 3;
        int elementRow = 0;
        int elementColumn = 0;
        for (int currentRow = 0; currentRow <= rows - subset; currentRow++)     //Create all possible sub matrices
        {
            for (int currentColumn = 0; currentColumn <= columns - subset; currentColumn++)
            {
                for (int subsetRow = currentRow; subsetRow < currentRow + subset; subsetRow++)
                {
                    for (int subsetColumn = currentColumn; subsetColumn < currentColumn + subset; subsetColumn++)
                    {
                        sum += matrix[subsetRow, subsetColumn];
                    }
                }
                if (sum > maxSum)                                               //Find the sub matrix with max sum
                {
                    maxSum = sum;
                    elementRow = currentRow;
                    elementColumn = currentColumn;
                    sum = 0;
                }
            }
        }

        Console.WriteLine("The elements of the submatrix with max sum are:");
        for (int row = 0; row < subset; row++)
        {
            for (int column = 0; column < subset; column++)
            {
                Console.Write("{0,3} ", matrix[elementRow + row, elementColumn + column]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Their sum is {0}", maxSum);
    }
}