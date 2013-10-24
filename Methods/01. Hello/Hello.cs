using System;

namespace HelloToYou
{
    public class Hello
    {
        public static string Greet(string name)
        {
            string greeting = string.Format("Hello, {0}!", name);
            return greeting;
        }

        static void Main()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            string greeting = Greet(name);
            Console.WriteLine(greeting);
        }
    }
}