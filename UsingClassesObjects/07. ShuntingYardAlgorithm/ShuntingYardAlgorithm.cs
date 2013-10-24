using System;
using System.Collections.Generic;

class ShuntingYardAlorithm
{
    static string ConvertToExpression(string input)
    {
        string expression = input;
        expression = expression.Replace(" ", string.Empty);
        expression = expression.Replace(",-", ",0-");
        expression = expression.Replace("(-", "(0-");
        expression = expression.Replace("ln", "L");
        expression = expression.Replace("sqrt", "S");
        expression = expression.Replace("pow", string.Empty);
        return expression;
    }

    static string GenerateNumberOrSign(string expression, ref int sign)
    {
        string currentSign = string.Empty;
        if (char.IsDigit(expression[sign]))
        {
            while (sign < expression.Length && (char.IsDigit(expression[sign]) || expression[sign] == '.'))
            {
                currentSign += expression[sign];
                sign++;
            }
        }
        else
        {
            currentSign += expression[sign];
            sign++;
        }

        return currentSign;
    }

    static void ExecuteOparation(Stack<string> operators, Stack<string> numbers)
    {
        double result = DefineOperation(operators, numbers);
        numbers.Push(result.ToString());
    }

    static double DefineOperation(Stack<string> operators, Stack<string> numbers)
    {
        double result = 0;
        string currentOperator = operators.Peek();
        operators.Pop();
        switch (currentOperator)
        {
            case "+":
                result = ExecuteAddition(numbers);
                return result;
            case "-":
                result = ExecuteSubtraction(numbers);
                return result;
            case "*":
                result = ExecuteMultiplication(numbers);
                return result;
            case "/":
                result = ExecuteDivision(numbers);
                return result;
            case ",":
                result = ExecutePower(numbers);
                return result;
            case "L":
                result = ExecuteLogarithm(numbers);
                return result;
            case "S":
                result = ExecuteSquareRoot(numbers);
                return result;
            default:
                return 0;
        }
    }

    static double ExecuteAddition(Stack<string> numbers)
    {
        double secondNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        double firstNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        double result = firstNumber + secondNumber;
        return result;
    }

    static double ExecuteSubtraction(Stack<string> numbers)
    {
        double secondNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        double firstNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        double result = firstNumber - secondNumber;
        return result;
    }

    static double ExecuteMultiplication(Stack<string> numbers)
    {
        double secondNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        double firstNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        double result = firstNumber * secondNumber;
        return result;
    }

    static double ExecuteDivision(Stack<string> numbers)
    {
        double secondNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        double firstNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        double result = firstNumber / secondNumber;
        return result;
    }

    static double ExecutePower(Stack<string> numbers)
    {
        double secondNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        double firstNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        double result = Math.Pow(firstNumber, secondNumber);
        return result;
    }

    static double ExecuteLogarithm(Stack<string> numbers)
    {
        double firstNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        if (firstNumber < 0)
        {
            Console.WriteLine("You cannot calculate logarithm of negative number");
            return 0;
        }

        double result = Math.Log(firstNumber);
        return result;
    }

    static double ExecuteSquareRoot(Stack<string> numbers)
    {
        double firstNumber = double.Parse(numbers.Peek());
        numbers.Pop();
        if (firstNumber < 0)
        {
            Console.WriteLine("You cannot calculate sqare root of negative number");
            return 0;
        }

        double result = Math.Sqrt(firstNumber);
        return result;
    }

    static void CheckCorrectness(Stack<string> operators, Stack<string> numbers, int functions)
    {
        if (numbers.Count == 2 || functions == 1)
        {
            ExecuteOparation(operators, numbers);
        }

        if (operators.Count > 0 || numbers.Count > 1)
        {
            Console.WriteLine("You enter incorrect mathematical expression");
        }
        else
        {
            Console.WriteLine("The answer is {0}", numbers.Peek());
        }
    }

    static void Main()
    {
        ////Examples from the presentation should be transformed in following format
        //// ((3 + 5.3) * 2.7) - (ln(22)) / pow(2.2,(-1.7)))
        //// pow(2,3.14) * ((3 - ((3 * sqrt(2)) - 3.2)) + (1.5 * 0.3))

        Console.WriteLine("Enter mathematical expression");
        Console.WriteLine("To show the precedence or operation you should ALWAYS write brackets \"(\" \")\"");
        Console.WriteLine("To use negative numbers you should round them with brackets \"(\" \")\"");
        Console.WriteLine("You can use operators \"+\" \"-\" \"/\" \"*\"");
        Console.WriteLine("You can use integer and real numbers with decimal separator \".\"");
        Console.WriteLine("You can use functions \"ln(x)\" \"sqrt(x)\" \"pow(x,y)\"");
        Console.WriteLine("You can write spaces");
        string input = Console.ReadLine();
        string expression = ConvertToExpression(input);                       ////Convert the input in suitable variant

        bool isOperation = false;                                             ////There are enough number to execute operation
        Stack<string> numbers = new Stack<string>();
        Stack<string> operators = new Stack<string>();
        int functions = 0;                                                    ////ln and sqrt functions in the operator stack
        bool isFunction = false;                                              ////Last operator is ln or sqrt function
        int leftBrackets = 0;                                                 ////Number of opened brackets
        bool rightBracket = false;                                            ////Last operator is closing bracket
        int sign = 0;                                                         ////Current position in the expression

        while (sign < expression.Length)
        {
            string currentSign = GenerateNumberOrSign(expression, ref sign);  ////Generate next number or operator from the expression

            double parseNumber;
            bool isNumber = double.TryParse(currentSign, out parseNumber);    ////Define its type
            if (isNumber)
            {
                numbers.Push(currentSign);
            }
            else if (currentSign == "(")
            {
                leftBrackets++;
            }
            else if (currentSign == ")")
            {
                leftBrackets--;
                rightBracket = true;
            }
            else if (currentSign == "L" || currentSign == "S")
            {
                operators.Push(currentSign);
                isFunction = true;
                functions++;
            }
            else
            {
                isFunction = false;
                operators.Push(currentSign);
            }
            
            isOperation = (numbers.Count > 1) && (numbers.Count == operators.Count + 1 - functions);
            if (isOperation && !isFunction && leftBrackets == 0)                    ////Execute operation (if it should be)
            {
                ExecuteOparation(operators, numbers);
                if (functions > 0 && (operators.Peek() == "L" || operators.Peek() == "S"))
                {
                    isFunction = true;
                }
            }
            else if (isOperation && !isFunction && leftBrackets > 0 && rightBracket == true)
            {
                ExecuteOparation(operators, numbers);
                if (functions > 0 && (operators.Peek() == "L" || operators.Peek() == "S"))
                {
                    isFunction = true;
                }
            }

            if (isFunction && numbers.Count > 0 && rightBracket == true)
            {
                ExecuteOparation(operators, numbers);
                if (functions > 0)
                {
                    functions--;
                }
            }

            rightBracket = false;
        }

        CheckCorrectness(operators, numbers, functions);                              ////Execute last operation and check correctness
    }
}