using System;

namespace Challange
{
    public class LeapYear
    {
        public static bool IsLeapYear(int y)
        {
            if (y % 400 == 0)
            {
                return true;
            }
            else if(y % 100 == 0)
            {
                return true;
            }
            else if(y % 4 == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            // Create a method called IsLeapYear().
            // That method should accept a year as input.
            // The output should be a boolean.
        string input = Console.ReadLine();
        int S = Convert.ToInt32(input);
        bool hasil = IsLeapYear(S);
        Console.WriteLine(hasil);

        }
    }
}
