using System;

class SubtractionMultiplication
{
    static int CalculateSubtractPower(int firstMembers, int secondMembers)
    {
        int subtractPower = firstMembers;
        if (secondMembers > firstMembers)
        {
            subtractPower = secondMembers;
        }

        return subtractPower;
    }

    static int[] EnterDigits(int[] array, int digits)
    {
        for (int position = 0; position < digits; position++)
        {
            array[position] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    static int SubtractDigits(int position, int[] firstArray, int[] secondArray)
    {
        int result = firstArray[position] - secondArray[position];
        return result;
    }

    static int CalculatePower(int firstPower, int secondPower)
    {
        int power = 0;
        if (firstPower == 0 || secondPower == 0 || firstPower == 1 || secondPower == 1)
        {
            power = firstPower + secondPower;
        }
        else
        {
            power = firstPower * secondPower;
        }

        return power;
    }

    static int[] MultyplyCoefficients(int productPower, int firstMembers, int secondMembers, int[] firstArray, int[] secondArray)
    {
        int[] product = new int[productPower + 1];
        for (int firstPosition = 0; firstPosition < firstMembers; firstPosition++)
        {
            for (int secondPosition = 0; secondPosition < secondMembers; secondPosition++)
            {
                int power = CalculatePower(firstPosition, secondPosition);
                int coefficient = firstArray[firstPosition] * secondArray[secondPosition];
                product[power] += coefficient;
            }
        }

        return product;
    }

    static void Print(int[] array)
    {
        string output = string.Empty;
        for (int currentCoefficient = array.Length - 1; currentCoefficient >= 0; currentCoefficient--)
        {
            if (currentCoefficient > 1)
            {
                output += string.Format("{0}x{1} + ", array[currentCoefficient], currentCoefficient);
            }
            else if (currentCoefficient == 1)
            {
                output += string.Format("{0}x + ", array[currentCoefficient]);
            }
            else
            {
                output += string.Format("{0}", array[currentCoefficient]);
            }
        }

        Console.WriteLine(output);
    }

    static void Main()
    {
        Console.WriteLine("Enter members of the first polynomial");
        int firstMembers = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter members of the second polynomial");
        int secondMembers = int.Parse(Console.ReadLine());

        int subtractPower = CalculateSubtractPower(firstMembers, secondMembers);
        int[] firstPolynomial = new int[subtractPower];
        int[] secondPolynomial = new int[subtractPower];
        int[] subtract = new int[subtractPower];

        Console.WriteLine("Enter the coefficients of the first polynomial from the last one");
        EnterDigits(firstPolynomial, firstMembers);

        Console.WriteLine("Enter the coefficients of the second polynomial from the last one");
        EnterDigits(secondPolynomial, secondMembers);

        for (int position = 0; position < subtractPower; position++)
        {
            int coefficientSum = SubtractDigits(position, firstPolynomial, secondPolynomial);
            subtract[position] = coefficientSum;
        }

        Console.WriteLine("The polynomial after subtraction is:");
        Print(subtract);

        int productPower = CalculatePower(firstMembers - 1, secondMembers - 1);
        int[] multiply = new int[productPower];
        multiply = MultyplyCoefficients(productPower, firstMembers, secondMembers, firstPolynomial, secondPolynomial);

        Console.WriteLine("The polynomial after multiplication is:");
        Print(multiply);
    }
}