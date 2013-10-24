using System;

class TriangleArea
{
    static double FirstMethod(byte method)
    {
        Console.WriteLine("Enter side in cm");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the altitude to the side in cm");
        double altitude = double.Parse(Console.ReadLine());
        double area = (side * altitude) / 2;
        return area;
    }

    static double SecondMethod(byte method)
    {
        Console.WriteLine("Enter first side in cm");
        double firstSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second side in cm");
        double secondSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third side in cm");
        double thirdSide = double.Parse(Console.ReadLine());
        double perimeter = firstSide + secondSide + thirdSide;
        double area = Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));
        return area;
    }

    static double ThirdMethod(byte method)
    {
        Console.WriteLine("Enter first side in cm");
        double firstSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second side in cm");
        double secondSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the angle in degrees (between 0 and 180)");
        double angle = double.Parse(Console.ReadLine());
        double radianAngle = (Math.PI / 180) * angle;
        double sinAngle = Math.Sin(radianAngle);
        double area = (firstSide * secondSide * sinAngle) / 2;
        return area;
    }

    static void Main()
    {
        Console.WriteLine("Calculate the area of triangle by given:");
        Console.WriteLine("1 Sade and altitude");
        Console.WriteLine("2 Three sides");
        Console.WriteLine("3 Two sides and angle between them");
        Console.WriteLine("Choose the method and enter its number");
        byte method;
        double area = 0;
        bool correctMethod = true;

        do
        {
            bool isNumber = byte.TryParse(Console.ReadLine(), out method);
            correctMethod = (isNumber && method < 4);
            if (!correctMethod)
            {
                Console.WriteLine("You enter invalid method!\n\rPlease Try again!");
            }
        }
        while (!correctMethod);

        switch(method)
        {
            case 1:
                area = FirstMethod(method);
                break;
            case 2:
                area = SecondMethod(method);
                break;
            case 3:
                area = ThirdMethod(method);
                break;
        }

        Console.WriteLine("The area of the triangle is {0} cm*cm", area);
    }
}