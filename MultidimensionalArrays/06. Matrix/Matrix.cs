using System;

class Matrix
{
    static int[,] Add(int[,] firstMatrix, int[,] secondMatrix, bool possibleAdd)
    {
        if (possibleAdd)
        {
            int[,] sum = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
            for (int currentRow = 0; currentRow < firstMatrix.GetLength(0); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < firstMatrix.GetLength(1); currentColumn++)
                {
                    sum[currentRow, currentColumn] = firstMatrix[currentRow, currentColumn] + secondMatrix[currentRow, currentColumn];
                }
            }
            return sum;
        }
        else
        {
            Console.WriteLine("It is impossible to add the two matrices");
            return new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
        }
    }

    static int[,] Subtract(int[,] firstMatrix, int[,] secondMatrix, bool possibleAdd)
    {
        if (possibleAdd)
        {
            int[,] subtract = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
            for (int currentRow = 0; currentRow < firstMatrix.GetLength(0); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < firstMatrix.GetLength(1); currentColumn++)
                {
                    subtract[currentRow, currentColumn] = firstMatrix[currentRow, currentColumn] - secondMatrix[currentRow, currentColumn];
                }
            }
            return subtract;
        }
        else
        {
            Console.WriteLine("It is impossible to subtract the two matrices");
            return new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
        }
    }

    static int[,] Multiply(int[,] firstMatrix, int[,] secondMatrix, bool possibleMultiply)
    {
        if (possibleMultiply)
        {
            int[,] multiply = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            for (int currentRow = 0; currentRow < firstMatrix.GetLength(0); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < secondMatrix.GetLength(1); currentColumn++)
                {
                    for (int count = 0; count < firstMatrix.GetLength(1); count++)
                    {
                        multiply[currentRow, currentColumn] += firstMatrix[currentRow, count] * secondMatrix[count, currentColumn];
                    }
                }
            }
            return multiply;
        }
        else
        {
            Console.WriteLine("It is impossible to multiply the two matrices");
            return new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        }
    }

    static int IndexAccess(int[,] matrix, int row, int column)
    {
        if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
        {
            Console.WriteLine("The element on position [{0},{1}] in first matrix has value {2}",
            row, column, matrix[row, column]);
            return matrix[row, column];
        }
        else
        {
            Console.WriteLine("There is no such element in the matrix");
        }
        return 0;
    }

    static string[,] ConvertToString(int[,] matrix)
    {
        string[,] convertedMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];
        for (int currentRow = 0; currentRow < matrix.GetLength(0); currentRow++)
        {
            for (int currentColumn = 0; currentColumn < matrix.GetLength(1); currentColumn++)
            {
                convertedMatrix[currentRow, currentColumn] = matrix[currentRow, currentColumn].ToString();
            }
        }
        return convertedMatrix;
    }

    static int[,] Declare()
    {
        Console.WriteLine("Enter number rows of matrix");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number columns of matrix");
        int columns = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, columns];
        Console.WriteLine("Enter elements of first matrix");
        for (int currentRow = 0; currentRow < rows; currentRow++)
        {
            for (int currentColumn = 0; currentColumn < columns; currentColumn++)
            {
                matrix[currentRow, currentColumn] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    static void Print(int[,] matrix, string name)
    {
        Console.WriteLine("Elements of the matrix {0} are", name);
        for (int currentRow = 0; currentRow < matrix.GetLength(0); currentRow++)
        {
            for (int currentColumn = 0; currentColumn < matrix.GetLength(1); currentColumn++)
            {
                Console.Write("{0} ", matrix[currentRow, currentColumn]);
            }
            Console.WriteLine();
        }
    }

    static void Print(string[,] matrix, string name)
    {
        Console.WriteLine("Elements of the matrix {0} are", name);
        for (int currentRow = 0; currentRow < matrix.GetLength(0); currentRow++)
        {
            for (int currentColumn = 0; currentColumn < matrix.GetLength(1); currentColumn++)
            {
                Console.Write("{0} ", matrix[currentRow, currentColumn]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] firstMatrix = Declare();
        int[,] secondMatrix = Declare();
        bool possibleAdd = false;
        bool possibleMultiply = false;

        if (firstMatrix.GetLength(0) == secondMatrix.GetLength(0) && firstMatrix.GetLength(1) == secondMatrix.GetLength(1))
        {
            possibleAdd = true;
        }
        if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
        {
            possibleMultiply = true;
        }

        int[,] addition = Add(firstMatrix, secondMatrix, possibleAdd);
        Print(addition, "Addition");
        int[,] subtraction = Subtract(firstMatrix, secondMatrix, possibleAdd);
        Print(subtraction, "Substraction");
        int[,] multiplication = Multiply(firstMatrix, secondMatrix, possibleMultiply);
        Print(multiplication, "Multiplication");
        string[,] conversionFirst = ConvertToString(firstMatrix);
        Print(conversionFirst, "Conversion of First Matrix");
        string[,] conversionSecond = ConvertToString(secondMatrix);
        Print(conversionSecond, "Conversion of Second Matrix");

        Console.WriteLine("Enter index of row");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index of column");
        int column = int.Parse(Console.ReadLine());
        int numberFirstMatrix = IndexAccess(firstMatrix, row, column);
        int numberSecondMatrix = IndexAccess(secondMatrix, row, column);
    }
}