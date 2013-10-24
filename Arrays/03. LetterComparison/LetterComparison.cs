using System;

class LetterComparison
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements in the arrays");
        int elements = int.Parse(Console.ReadLine());
        string firstArray = "";
        string secondArray = "";

        Console.WriteLine("Enter the elements of the first array (symbols)");
        for (int count = 0; count < elements; count++)
        {
            firstArray += Console.ReadLine();
        }
        Console.WriteLine("Enter the elements of the second array (symbols)");
        for (int count = 0; count < elements; count++)
        {
            secondArray += Console.ReadLine();
        }

        //or
        //Console.WriteLine("Enter the elements of the first arrays consecutively on one row");
        //string firstArray = Console.ReadLine();
        //Console.WriteLine("Enter the elements of the second arrays consecutively on one row");
        //string secondArray = Console.ReadLine();

        firstArray = firstArray.ToLower();
        secondArray = secondArray.ToLower();
        bool areEqual = true;

        for (int count = 0; count < elements; count++)
        {
            if (firstArray[count] < secondArray[count])
            {
                Console.WriteLine("First array is lexicographically before Second array");
                areEqual = false;
                break;
            }
            if (firstArray[count] > secondArray[count])
            {
                Console.WriteLine("First array is lexicographically after Second array");
                areEqual = false;
                break;
            }
        }

        if (areEqual)
        {
            Console.WriteLine("First array is equal to the Second array");
        }
    }
}