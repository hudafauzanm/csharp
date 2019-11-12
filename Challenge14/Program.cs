using System;

namespace PalindromeDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please read the palindrome definition
            IsPalindrome("ipsum"); // false
            IsPalindrome("malam"); // true
            IsPalindrome("tidur"); // false
            IsPalindrome("kasur rusak"); // true
            IsPalindrome("ibu ratna antar ubi"); // true

            Console.WriteLine(IsPalindrome("ipsum"));
            Console.WriteLine(IsPalindrome("malam"));
            Console.WriteLine(IsPalindrome("tidur"));
            Console.WriteLine(IsPalindrome("ibu ratna antar ubi"));
            Console.WriteLine(IsPalindrome("kasur rusak"));
        }

        static bool IsPalindrome(string text)
        {
            int length = text.Length;
                for (int i = 0; i < length / 2; i++)
                    {
                    if (text[i] != text[length - i - 1])
                    return false;
                    }
            return true;
        }
    }
}
