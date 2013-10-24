using System;

class EqualStrings
{
    static int currentRow;
    static int currentColumn;
    static string currentElement = "";
    static string[,] matrix;
    static int sequence = 0;
    static int maxSequence = 0;
    static string sequenceElement = "";
    static bool same = true;

    static void Check()
    {
        if (matrix[currentRow, currentColumn] == currentElement)
        {
            sequence++;
        }
        else
        {
            same = false;
            if (sequence > maxSequence)
            {
                maxSequence = sequence;
                sequenceElement = currentElement;
                sequence = 0;
            }
        }
    }

    static void CheckEnd()
    {
        if (sequence > maxSequence)
        {
            maxSequence = sequence;
            sequenceElement = currentElement;
        }
        sequence = 0;
    }

    static void HorizontalLine(int rows, int columns)
    {
        //Check for a horizontal line
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                currentElement = matrix[row, column];
                currentColumn = column + 1;
                currentRow = row;
                while (same && currentColumn < columns)
                {
                    Check();
                    currentColumn++;
                }
                same = true;
            }
            CheckEnd();
        }
    }

    static void VerticalLine(int rows, int columns)
    {
        //Check for a vertical line
        for (int column = 0; column < columns; column++)
        {
            for (int row = 0; row < rows; row++)
            {
                currentElement = matrix[row, column];
                currentRow = row + 1;
                currentColumn = column;
                while (same && currentRow < rows)
                {
                    Check();
                    currentRow++;
                }
                same = true;
            }
            CheckEnd();
        }
    }

    static void FirstDiagonalLine(int rows, int columns)
    {
        //Check for a first diagonal line
        //First angle
        for (int length = 1; length <= Math.Min(rows, columns); length++)
        {
            for (int count = 0; count < length; count++)
            {
                currentElement = matrix[rows - length + count, count];
                currentColumn = count + 1;
                currentRow = rows - length + count + 1;
                while (same && currentColumn < columns && currentRow < rows)
                {
                    Check();
                    currentRow++;
                    currentColumn++;
                }
                same = true;
            }
            CheckEnd();
        }

        //Middle part
        if (rows > columns)
        {
            for (int count = rows - columns - 1; count >= 0; count--)
            {
                for (int length = 0; length < columns; length++)
                {
                    currentElement = matrix[length + count, length];
                    currentColumn = length + 1;
                    currentRow = length + count + 1;
                    while (same && currentColumn < columns && currentRow < rows)
                    {
                        Check();
                        currentRow++;
                        currentColumn++;
                    }
                    same = true;
                }
                CheckEnd();
            }
        }

        if (rows < columns)
        {
            for (int count = 1; count <= columns - rows; count++)
            {
                for (int length = 0; length < rows; length++)
                {
                    currentElement = matrix[length, length + count];
                    currentRow = length + 1;
                    currentColumn = length + count + 1;
                    while (same && currentColumn < columns && currentRow < rows)
                    {
                        Check();
                        currentRow++;
                        currentColumn++;
                    }
                    same = true;
                }
                CheckEnd();
            }
        }

        //Second angle
        for (int count = columns - Math.Min(rows, columns) + 1, down = 1; count < columns; count++, down++)
        {
            for (int length = 0; length < Math.Min(rows, columns) - down; length++)
            {
                currentElement = matrix[length, count + length];
                currentColumn = count + length + 1;
                currentRow = length + 1;
                while (same && currentColumn < columns && currentRow < rows)
                {
                    Check();
                    currentRow++;
                    currentColumn++;
                }
                same = true;
            }
            CheckEnd();
        }
    }

    static void SecondDiagonalLine(int rows, int columns)
    {
        //Check for a second diagonal line
        //First angle
        for (int length = 1; length <= Math.Min(rows, columns); length++)
        {
            for (int count = 0; count < length; count++)
            {
                currentElement = matrix[rows - length + count, columns - 1 - count];
                currentColumn = columns - length - count - 1;
                currentRow = rows - length + count + 1;
                while (same && currentColumn < columns && currentRow < rows && currentColumn >= 0 && currentRow >= 0)
                {
                    Check();
                    currentRow++;
                    currentColumn--;
                }
                same = true;
            }
            CheckEnd();
        }

        //Middle part
        if (rows > columns)
        {
            for (int count = rows - columns - 1; count >= 0; count--)
            {
                for (int length = 0; length < columns; length++)
                {
                    currentElement = matrix[length + count, columns - 1 - length];
                    currentColumn = columns - length - 2;
                    currentRow = length + count + 1;
                    while (same && currentColumn < columns && currentRow < rows && currentColumn >= 0 && currentRow >= 0)
                    {
                        Check();
                        currentRow++;
                        currentColumn--;
                    }
                    same = true;
                }
                CheckEnd();
            }
        }

        if (rows < columns)
        {
            for (int count = columns - 2; count >= rows - 1; count--)
            {
                for (int length = 0; length < rows; length++)
                {
                    currentElement = matrix[length, count - length];
                    currentRow = length + 1;
                    currentColumn = count - length - 1;
                    while (same && currentColumn < columns && currentRow < rows && currentColumn >= 0 && currentRow >= 0)
                    {
                        Check();
                        currentRow++;
                        currentColumn--;
                    }
                    same = true;
                }
                CheckEnd();
            }
        }

        //Second angle
        for (int count = Math.Min(rows, columns) - 2, down = 1; count >= 0; count--, down++)
        {
            for (int length = 0; length < Math.Min(rows, columns) - down; length++)
            {
                currentElement = matrix[length, count - length];
                currentColumn = count - length - 1;
                currentRow = length + 1;
                while (same && currentColumn < columns && currentRow < rows && currentColumn >= 0 && currentRow >= 0)
                {
                    Check();
                    currentRow++;
                    currentColumn--;
                }
                same = true;
            }
            CheckEnd();
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number of rows");
        byte rows = byte.Parse(Console.ReadLine());                         //Small number
        Console.WriteLine("Enter number of columns");
        byte columns = byte.Parse(Console.ReadLine());                      //Small number
        matrix = new string[rows, columns];

        Console.WriteLine("Enter the elements of the matrix");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                matrix[row, column] = Console.ReadLine();
            }
        }

        HorizontalLine(rows, columns);

        VerticalLine(rows, columns);

        FirstDiagonalLine(rows, columns);

        SecondDiagonalLine(rows, columns);

        Console.WriteLine("The elements of the line with max length are:");
        for (int count = 0; count < maxSequence; count++)
        {
            Console.Write("{0} ", sequenceElement);
        }
        Console.WriteLine();
        Console.WriteLine("The length of the Line is {0}", maxSequence);
    }
}