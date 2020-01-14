using System;

namespace Challange
{
    public class EvenOdd 
    {
        public static bool IsEven(int S)
            {
                if(S%2 == 0)
                {
                return true;
                }
                else
                {
                return false;
                }
            }

        public static bool IsOdd(int S)
        {
            if(S%2 == 1)
            {
                return true;
                }
            else{
                return false;
                }
        }

        static void Main(string[] args)
        {
            // Create new method with ability to detect odd or even number.
            // Example:
            // IsOdd(4) // false
            // IsEven(8) // true
            string input = Console.ReadLine();
            int S = Convert.ToInt32(input);
            bool hasil = IsEven(S);
            bool hasil2 = IsOdd(S); 

            Console.WriteLine("IsOdd(4) {0}",hasil);
            Console.WriteLine("IsEven(8) {0}",hasil2);
        }
    }
}
