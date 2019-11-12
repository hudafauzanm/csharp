using System;

namespace YourName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get your name by using Console.ReadLine()
            // Example output: "Hello, my name is Salamander.",
            // depends on user input.
            Console.WriteLine("Siapa Namamu?");
            string nama = Console.ReadLine();
            Console.WriteLine("Hello, my name is "  +nama);
        }
    }
}
