using System;
using System.Text;

class Brackets
{
    static void Main()
    {
        Console.WriteLine("Enter expression");
        string expression = Console.ReadLine();
        ////If brackets are written correctly left brackets will be always more than rigth and at the end will be zero
        int leftBrackets = 0;
        bool correct = true;
        for (int sign = 0; sign < expression.Length; sign++)
        {
            if (expression[sign] == '(')
            {
                leftBrackets++;
            }
            else if (expression[sign] == ')')
            {
                leftBrackets--;
            }

            if (leftBrackets < 0)
            {
                correct = false;
            }
        }

        if (leftBrackets > 0)
        {
            correct = false;
        }

        Console.WriteLine("Brackets are correctly written: {0}", correct);
    }
}