using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit
{
    class Rabbit
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputData = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int maxJump = inputData.Length;
            int[] places = new int[maxJump];
            for (int i = 0; i < maxJump; i++)
            {
                places[i] = int.Parse(inputData[i]);
            }
            bool isPath = false;
            int maxPath = 1;
            int currentPath = 1;
            for (int jump = maxJump - 1; jump >= 1; jump--)
            {
                for (int start = 0; start < maxJump; start++)
                {
                    byte[] copy = new byte[maxJump];
                    int position = start;
                    int nextPosition = start;
                    int startNumber = places[position];
                    int nextNumber = places[position];
                    do
                    {
                        isPath = false;
                        if (position + jump >= maxJump)
                        {
                            nextPosition = position + jump - maxJump;
                        }
                        else
                        {
                            nextPosition = position + jump;
                        }
                        nextNumber = places[nextPosition];

                        if (nextNumber > startNumber && copy[nextPosition] != 1)
                        {
                            currentPath++;
                            copy[position] = 1;
                            position = nextPosition;
                            startNumber = nextNumber;
                            isPath = true;
                        }
                    }
                    while (isPath);
                    if (currentPath > maxPath)
                    {
                        maxPath = currentPath;
                    }
                    currentPath = 1;
                }

            }
            Console.WriteLine(maxPath);
        }
    }
}
