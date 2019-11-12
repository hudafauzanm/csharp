using System;

namespace MirrorString
{
    class Program
    {
        static void Main(string[] args)
        {
            Mirror("--vv"); // Output: --vvvv--
            Console.WriteLine("--vv{0}",Mirror("--vv"));
        }

        static string Mirror(string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr); 
        }
    }
}
