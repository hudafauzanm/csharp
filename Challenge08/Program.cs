using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called IsLeapYear().
            // That method should accept a year as input.
            // The output should be a boolean.
        bool IsLeapYear(int y)
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
        Console.WriteLine(IsLeapYear(1004));

        }
    }
}
