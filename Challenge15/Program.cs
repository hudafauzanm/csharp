using System;

namespace Challange
{
    public class MirrorString
    {
        static void Main(string[] args)
        {
            Mirror("--vv"); // Output: --vvvv--
            string input = Console.ReadLine();
            string hasil = Mirror(input);
            Console.WriteLine("--vv{0}",Mirror("--vv"));
        }

        public static string Mirror(string input)
        {
            int ln = input.Length;
            for(int i=0; i<ln; i++)
                input += input[ln-i-1];

            return input;
        }
    }
}
