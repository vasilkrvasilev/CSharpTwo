using System;

class RandomSystem
{
    static int ConverToDecimal(string number, int numberBase)
    {
        int decimalNumber = 0;
        int length = number.Length;
        for (int digit = 0; digit < length; digit++)
        {
            string currentDigit = number.Substring(digit, 1);
            switch (currentDigit)
            {
                case "0":
                    break;
                case "1":
                    decimalNumber += (int)Math.Pow(numberBase, (length - 1 - digit));
                    break;
                case "2":
                    decimalNumber += (int)(2 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "3":
                    decimalNumber += (int)(3 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "4":
                    decimalNumber += (int)(4 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "5":
                    decimalNumber += (int)(5 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "6":
                    decimalNumber += (int)(6 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "7":
                    decimalNumber += (int)(7 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "8":
                    decimalNumber += (int)(8 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "9":
                    decimalNumber += (int)(9 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "A":
                    decimalNumber += (int)(10 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "B":
                    decimalNumber += (int)(11 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "C":
                    decimalNumber += (int)(12 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "D":
                    decimalNumber += (int)(13 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "E":
                    decimalNumber += (int)(14 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
                case "F":
                    decimalNumber += (int)(15 * Math.Pow(numberBase, (length - 1 - digit)));
                    break;
            }
        }

        return decimalNumber;
    }

    static string ConverFromDecimal(int decimalNumber, int numberBase)
    {
        string convertedNumber = string.Empty;
        while (decimalNumber > 0)
        {
            int currentDigit = decimalNumber % numberBase;
            decimalNumber /= numberBase;
            switch (currentDigit)
            {
                case 0:
                    convertedNumber = "0" + convertedNumber;
                    break;
                case 1:
                    convertedNumber = "1" + convertedNumber;
                    break;
                case 2:
                    convertedNumber = "2" + convertedNumber;
                    break;
                case 3:
                    convertedNumber = "3" + convertedNumber;
                    break;
                case 4:
                    convertedNumber = "4" + convertedNumber;
                    break;
                case 5:
                    convertedNumber = "5" + convertedNumber;
                    break;
                case 6:
                    convertedNumber = "6" + convertedNumber;
                    break;
                case 7:
                    convertedNumber = "7" + convertedNumber;
                    break;
                case 8:
                    convertedNumber = "8" + convertedNumber;
                    break;
                case 9:
                    convertedNumber = "9" + convertedNumber;
                    break;
                case 10:
                    convertedNumber = "A" + convertedNumber;
                    break;
                case 11:
                    convertedNumber = "B" + convertedNumber;
                    break;
                case 12:
                    convertedNumber = "C" + convertedNumber;
                    break;
                case 13:
                    convertedNumber = "D" + convertedNumber;
                    break;
                case 14:
                    convertedNumber = "E" + convertedNumber;
                    break;
                case 15:
                    convertedNumber = "F" + convertedNumber;
                    break;
            }
        }

        return convertedNumber;
    }

    static void Main()
    {
        Console.WriteLine("Enter number");
        string number = Console.ReadLine();
        Console.WriteLine("Enter base of the numeral system of the number");
        int numberBase = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter base of the new numeral system");
        int conversionBase = int.Parse(Console.ReadLine());

        int decimalNumber = ConverToDecimal(number, numberBase);
        string convertedNumber = ConverFromDecimal(decimalNumber, conversionBase);
        Console.WriteLine(
            "{0} in {1} based numerical system is equal to {2} in {3} based numerical system",
            convertedNumber, 
            conversionBase, 
            number, 
            numberBase);
    }
}