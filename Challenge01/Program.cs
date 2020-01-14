using System;

namespace Challange
{
    public class YourName
    {
        public static void Main(string[] args)
        {
            // Get your name by using Console.ReadLine()
            // Example output: "Hello, my name is Salamander.",
            // depends on user input.
            Console.WriteLine("Siapa Namamu?");
            string nama = Console.ReadLine();
            var input = Console.ReadLine();
            Console.WriteLine(input);

            Console.WriteLine("Hello, my name is "  +nama);
        }

        public static string PrintName(string input)
        {
            return input;
        }
    }
}
