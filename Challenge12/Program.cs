using System;

namespace ToUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a progam that be able to
            // transform all string into uppercase.
            string word = Console.ReadLine();
            string upperstr = word.ToUpper(); 
            Console.WriteLine(upperstr);
        }
    }
}
