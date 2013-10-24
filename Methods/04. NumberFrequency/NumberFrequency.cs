using System;

namespace Frequency
{
    public class NumberFrequency
    {
        public static int CountFrequency(int[] array, int number)
        {
            int frequency = 0;
            for (int position = 0; position < array.Length; position++)
            {
                if (array[position] == number)
                {
                    frequency++;
                }
            }

            return frequency;
        }

        static void Main()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of element in the array");
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];

            Console.WriteLine("Enter the elements of the array");
            for (int position = 0; position < elements; position++)
            {
                array[position] = int.Parse(Console.ReadLine());
            }

            int numberFrequency = CountFrequency(array, number);
            Console.WriteLine("{0} is repeated {1} times in the array", number, numberFrequency);
        }
    }
}