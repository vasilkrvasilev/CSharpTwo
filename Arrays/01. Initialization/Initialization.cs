using System;

class Initialization
{
    static void Main()
    {
        byte elements = 20;                                           //Small numbers
        byte multiply = 5;                                            //Small numbers
        byte[] array = new byte[elements];                            //Small numbers

        Console.WriteLine("First {0} numbers multiplied by {1}", elements, multiply);
        for (int count = 0; count < elements; count++)
        {
            array[count] = (byte)(count * multiply);
            Console.Write("{0} ", array[count]);
        }
    }
}