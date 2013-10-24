using System;

class TaskMenu
{
    static string Reverse(int number, string changedNumber, string input)
    {
        for (int count = 0; count < input.Length; count++)
        {
            int lastDigit = number % 10;
            changedNumber += lastDigit.ToString();
            number /= 10;
        }

        return changedNumber;
    }

    static double CalculateRoot(double numberOne, double numberTwo)
    {
        double root = -numberTwo / numberOne;
        return root;
    }

    static double CalculateAverage(int[] array)
    {
        double average = 0;
        for (int position = 0; position < array.Length; position++)
        {
            average += array[position];
        }

        average /= array.Length;
        return average;
    }

    static int[] EnterDigits(int[] array, int digits)
    {
        for (int position = 0; position < digits; position++)
        {
            array[position] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    static void ExecuteFirstTask(bool firstTask)
    {
        if (firstTask)
        {
            Console.WriteLine("Enter number");
            string input = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                bool isPositive = (number >= 0);
                if (isPositive)
                {
                    string changedNumber = string.Empty;
                    changedNumber = Reverse(number, changedNumber, input);
                    Console.WriteLine("Reversed number is {0}", changedNumber);
                }
                else
                {
                    Console.WriteLine("You enter negative number");
                }
            }
            else
            {
                Console.WriteLine("You enter invalid number");
            }
        }
    }

    static void ExecuteSecondTask(bool secondTask)
    {
        if (secondTask)
        {
            Console.WriteLine("Enter number of element in the sequence");
            string input = Console.ReadLine();
            int elements;
            bool isNumber = int.TryParse(input, out elements);
            if (isNumber)
            {
                bool isPositive = (elements > 0);
                if (isPositive)
                {
                    Console.WriteLine("Enter the elements of the sequense");
                    int[] sequence = new int[elements];
                    EnterDigits(sequence, elements);
                    Console.WriteLine("Average of the sequence is equal to {0}", CalculateAverage(sequence));
                }
                else
                {
                    Console.WriteLine("You enter negative number or zero");
                }
            }
            else
            {
                Console.WriteLine("You enter invalid number");
            }
        }
    }

    static void ExecuteThirdTask(bool thirdTask)
    {
        if (thirdTask)
        {
            Console.WriteLine("Enter first coefficient of the equation");
            string firstInput = Console.ReadLine();
            double firstCoefficient;
            bool firstIsNumber = double.TryParse(firstInput, out firstCoefficient);
            Console.WriteLine("Enter second coefficient of the equation");
            string secondInput = Console.ReadLine();
            double secondCoefficient;
            bool secondIsNumber = double.TryParse(secondInput, out secondCoefficient);
            if (firstIsNumber && secondIsNumber)
            {
                bool noZero = (firstCoefficient != 0);
                if (noZero)
                {
                    Console.WriteLine(
                        "Root of the equation {0}x + {1} = 0 is equal to {2}",
                        firstCoefficient, 
                        secondCoefficient, 
                        CalculateRoot(firstCoefficient, secondCoefficient));
                }
                else
                {
                    Console.WriteLine("You enter zero");
                }
            }
            else
            {
                Console.WriteLine("You enter invalid number");
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Choose a task:");
        Console.WriteLine("1 Reverse a number");
        Console.WriteLine("2 Calculate the average of a sequence");
        Console.WriteLine("3 Find the root of a linear equation");
        Console.WriteLine("Enter task number");

        byte task = byte.Parse(Console.ReadLine());
        while (task < 1 || task > 3)
        {
            Console.WriteLine("Invalid task!\n\rTry Again!");
            task = byte.Parse(Console.ReadLine());
        }

        bool firstTask = (task == 1);
        bool secondTask = (task == 2);
        bool thirdTask = (task == 3);

        ExecuteFirstTask(firstTask);

        ExecuteSecondTask(secondTask);

        ExecuteThirdTask(thirdTask);
    }
}