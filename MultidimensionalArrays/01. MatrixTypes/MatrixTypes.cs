using System;

class MatrixTypes
{
    static void Print(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)                           //Print matrix
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                Console.Write("{0,3} ", matrix[row, column]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void FirstMatrix(byte size)                                                //Fill first type of matrix
    {
        int[,] matrixOne = new int[size, size];
        int valueOne = 1;
        Console.WriteLine("\t\tThe First Type of Matrix\n\r");
        Console.WriteLine(new string('-', 50));

        for (int columnOne = 0; columnOne < size; columnOne++)
        {
            for (int rowOne = 0; rowOne < size; rowOne++)
            {
                matrixOne[rowOne, columnOne] = valueOne;
                valueOne++;
            }
        }

        Print(matrixOne);
    }

    static void SecondMatrix(byte size)                                                //Fill second type of matrix
    {
        int[,] matrixTwo = new int[size, size];
        int valueTwo = 1;
        int columnTwo = 0;
        Console.WriteLine("\t\tThe Second Type of Matrix\n\r");
        Console.WriteLine(new string('-', 50));

        while (valueTwo <= size * size)
        {
            for (int rowTwo = 0; rowTwo < size; rowTwo++)
            {
                matrixTwo[rowTwo, columnTwo] = valueTwo;
                valueTwo++;
            }
            columnTwo++;
            if (columnTwo < size)
            {
                for (int rowTwo = size - 1; rowTwo >= 0; rowTwo--)
                {
                    matrixTwo[rowTwo, columnTwo] = valueTwo;
                    valueTwo++;
                }
                columnTwo++;
            }
        }

        Print(matrixTwo);
    }

    static void ThirdMatrix(byte size)                                                //Fill third type of matrix
    {
        int[,] matrixThree = new int[size, size];
        int valueThree = 1;
        Console.WriteLine("\t\tThe Third Type of Matrix\n\r");
        Console.WriteLine(new string('-', 50));

        for (int length = 1; length <= size; length++)                               //Fill first angle of the matrix
        {
            for (int count = 0; count < length; count++)
            {
                matrixThree[size - length + count, count] = valueThree;
                valueThree++;
            }
        }

        for (int count = 1; count <= size; count++)                                 //Fill second angle of the matrix
        {
            for (int length = 0; length < size - count; length++)
            {
                matrixThree[length, count + length] = valueThree;
                valueThree++;
            }
        }

        Print(matrixThree);
    }

    static void FourthMatrix(byte size)
    {
        int[,] matrixFour = new int[size, size];
        int valueFour = 1;
        byte loop = 1;                                                            //Loop is equal to the 4 sides of the matrix 
        Console.WriteLine("\t\tThe Fouth Type of Matrix\n\r");
        Console.WriteLine(new string('-', 50));

        for (int position = 0; position < size; position++)                       //Fill the first row of the matrix
        {
            matrixFour[position, 0] = valueFour;
            valueFour++;
        }

        while (valueFour <= (size * size))                                        //Fill the rest of the matrix
        {
            for (int column = loop; column <= size - loop; column++)              //First side - left side
            {
                matrixFour[size - loop, column] = valueFour;
                valueFour++;
            }
            for (int row = size - loop; row >= loop; row--)                       //Second side - bottom side
            {
                matrixFour[row - 1, size - loop] = valueFour;
                valueFour++;
            }
            for (int column = size - loop - 1; column >= loop; column--)          //Third side - right side
            {
                matrixFour[loop - 1, column] = valueFour;
                valueFour++;
            }
            for (int row = loop; row <= size - loop - 1; row++)                   //Fourth side - top side
            {
                matrixFour[row, loop] = valueFour;
                valueFour++;
            }
            loop++;
        }

        Print(matrixFour);
    }

    static void FifthMatrix(byte size)                                             //Fill fifth type of matrix
    {
        int[,] matrixFive = new int[size, size];
        int valueFive = 1;
        Console.WriteLine("\t\tThe Fifth Type of Matrix\n\r");
        Console.WriteLine(new string('-', 50));

        for (int length = 1; length <= size; length++)                             //Fill first angle of the matrix
        {
            for (int count = 0; count < length; count++)
            {
                matrixFive[size - 1 - count, size - length + count] = valueFive;
                valueFive++;
            }
        }

        for (int count = 1; count <= size; count++)                                //Fill first angle of the matrix
        {
            for (int length = 0; length < size - count; length++)
            {
                matrixFive[size - 1 - count - length, length] = valueFive;
                valueFive++;
            }
        }

        Print(matrixFive);
    }

    static void Main()
    {
        Console.WriteLine("Enter number");
        byte size = byte.Parse(Console.ReadLine());                      //Small number

        FirstMatrix(size);

        SecondMatrix(size);

        ThirdMatrix(size);

        FourthMatrix(size);

        FifthMatrix(size);                                              //From the book
    }
}