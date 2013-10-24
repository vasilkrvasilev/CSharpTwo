using System;
using System.IO;
using System.Text;

class SubMatrix
{
    static void EnterMatrix(string writtenFile)
    {
        StreamWriter writer = new StreamWriter(writtenFile, true, Encoding.GetEncoding("UTF-8"));
        using (writer)
        {
            Console.WriteLine("Enter size of the matrix");
            int size = int.Parse(Console.ReadLine());
            writer.WriteLine(size);
            Console.WriteLine("Enter elements of the matrix row by row");
            for (int line = 0; line < size; line++)
            {
                string row = Console.ReadLine();
                writer.WriteLine(row);
            }
        }
    }

    static int[,] FillMatrix(string writtenFile)
    {
        int[,] matrix;
        StreamReader reader = new StreamReader(writtenFile, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            string currentLine = reader.ReadLine();
            int matrixSize = int.Parse(currentLine);
            matrix = new int[matrixSize, matrixSize];
            for (int currentRow = 0; currentRow < matrixSize; currentRow++)
            {
                currentLine = reader.ReadLine();
                string[] currentLineElements = currentLine.Split(' ');
                for (int currentColumn = 0; currentColumn < matrixSize; currentColumn++)
                {
                    matrix[currentRow, currentColumn] = int.Parse(currentLineElements[currentColumn]);
                }
            }
        }

        return matrix;
    }

    static void CreateResult(string resultFile, int[,] matrix, int submatrixSize, int elementRow, int elementColumn, int maxSum)
    {
        StreamWriter resultWriter = new StreamWriter(resultFile, true, Encoding.GetEncoding("UTF-8"));
        using (resultWriter)
        {
            resultWriter.WriteLine("The submatrix with size {0} and max sum of its elements is:", submatrixSize);
            for (int subRow = 0; subRow < submatrixSize; subRow++)
            {
                for (int subColumn = 0; subColumn < submatrixSize; subColumn++)
                {
                    resultWriter.Write("{0} ", matrix[elementRow + subRow, elementColumn + subColumn]);
                }

                resultWriter.WriteLine();
            }

            resultWriter.WriteLine("Their sum is: {0}", maxSum);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter written file name (instead \\ use \\\\)");
        string writtenFile = Console.ReadLine();                                    ////matrix.txt
        Console.WriteLine("Enter result file name (instead \\ use \\\\)");
        string resultFile = Console.ReadLine();                                     ////result.txt

        EnterMatrix(writtenFile);
        int[,] matrix = FillMatrix(writtenFile);
        int submatrixSize = 2;
        int sum = 0;
        int maxSum = int.MinValue;
        int elementRow = 0;
        int elementColumn = 0;

        for (int rows = 0; rows < matrix.GetLength(0) - submatrixSize; rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1) - submatrixSize; columns++)
            {
                for (int subRow = rows; subRow < submatrixSize; subRow++)
                {
                    for (int subColumn = columns; subColumn < submatrixSize; subColumn++)
                    {
                        sum += matrix[subRow, subColumn];
                    }
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    elementRow = rows;
                    elementColumn = columns;
                }

                sum = 0;
            }
        }

        CreateResult(resultFile, matrix, submatrixSize, elementRow, elementColumn, maxSum);
    }
}