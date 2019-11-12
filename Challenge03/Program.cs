using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new method called "CountString".
            // That method should accept a string and will
            // return length of characters input.
            int CountString(string S)
            {
                
                int count = S.Length - S.Split(' ').Length + 1;
                return count;
            }
                
            Console.WriteLine("'Hello World!' have {0} characters", CountString("Hello World!"));
            Console.WriteLine("'Hello Universe!' have {0} characters", CountString("Hello Universe!"));
        }
    }
}
