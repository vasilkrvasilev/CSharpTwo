using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Laser
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] data = input.Split(' ');
        int[] size = new int[3];
        for (int i = 0; i < 3; i++)
        {
            size[i] = int.Parse(data[i]);
        }
        byte[, ,] matrix = new byte[size[0], size[1], size[2]];
        for (int row = 0; row < size[1]; row++)
        {
            matrix[0, row, 0] = 1;
            matrix[0, row, size[2] - 1] = 1;
            matrix[size[0] - 1, row, 0] = 1;
            matrix[size[0] - 1, row, size[2] - 1] = 1;
        }
        for (int layer = 0; layer < size[2]; layer++)
        {
            matrix[0, 0, layer] = 1;
            matrix[0, size[1] - 1, layer] = 1;
            matrix[size[0] - 1, 0, layer] = 1;
            matrix[size[0] - 1, size[1] - 1, layer] = 1;
        }
        for (int column = 0; column < size[0]; column++)
        {
            matrix[column, 0, 0] = 1;
            matrix[column, size[1] - 1, 0] = 1;
            matrix[column, 0, size[2] - 1] = 1;
            matrix[column, size[1] - 1, size[2] - 1] = 1;
        }

        string startPoint = Console.ReadLine();
        string[] startPointData = startPoint.Split(' ');
        int[] start = new int[3];
        for (int i = 0; i < 3; i++)
        {
            start[i] = int.Parse(startPointData[i]);
        }

        string directionInput = Console.ReadLine();
        string[] directionData = directionInput.Split(' ');
        int[] direction = new int[3];
        for (int i = 0; i < 3; i++)
        {
            direction[i] = int.Parse(directionData[i]);
        }

        int currentNumber = matrix[start[0], start[1], start[2]];
        while (currentNumber == 0)
        {
            matrix[start[0], start[1], start[2]] = 1;
            for (int count = 0; count < 3; count++)
            {
                start[count] += direction[count];
            }
            for (int count = 0; count < 3; count++)
            {
                if (start[count] == 0 || start[count] == size[count] - 1)
                {
                    direction[count] = -direction[count];
                }
            }
            currentNumber = matrix[start[0], start[1], start[2]];
        }
        for (int count = 0; count < 3; count++)
        {
            Console.Write("{0} ", start[count] - direction[count]);
        }
    }
}