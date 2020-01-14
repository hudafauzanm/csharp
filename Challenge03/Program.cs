using System;

namespace Challange
{
    public class StringLength
    {
        static void Main(string[] args)
        {
            // Create new method called "CountString".
            // That method should accept a string and will
            // return length of characters input.
            string kalimat = Console.ReadLine();
            int hasil = CountString(kalimat);
            Console.WriteLine("'Hello World!' have {0} characters", hasil);
        }

        public static int CountString(string kalimat)
        {
                int count = kalimat.Length - kalimat.Split(' ').Length + 1;
                return count;
        }
    }
}
