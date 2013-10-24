using System;

class AddPolynomials
{
    static int CalculateSumPower(int firstMembers, int secondMembers)
    {
        int sumPower = firstMembers;
        if (secondMembers > firstMembers)
        {
            sumPower = secondMembers;
        }

        return sumPower;
    }

    static int[] EnterCoefficients(int[] array, int coefficients)
    {
        for (int position = 0; position < coefficients; position++)
        {
            array[position] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    static int AddCoefficients(int position, int[] firstArray, int[] secondArray)
    {
        int result = firstArray[position] + secondArray[position];
        return result;
    }

    static void Print(int[] array)
    {
        string output = string.Empty;
        Console.WriteLine("The polynomial after addition is:");
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

        int sumPower = CalculateSumPower(firstMembers, secondMembers);
        int[] firstPolynomial = new int[sumPower];
        int[] secondPolynomial = new int[sumPower];
        int[] sum = new int[sumPower];

        Console.WriteLine("Enter the coefficients of the first polynomial from the last one");
        EnterCoefficients(firstPolynomial, firstMembers);

        Console.WriteLine("Enter the coefficients of the second polynomial from the last one");
        EnterCoefficients(secondPolynomial, secondMembers);

        for (int position = 0; position < sumPower; position++)
        {
            int coefficientSum = AddCoefficients(position, firstPolynomial, secondPolynomial);
            sum[position] = coefficientSum;
        }

        Print(sum);
    }
}