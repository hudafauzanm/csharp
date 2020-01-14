using System;

namespace Challange
{
    public class ToUpperCase
    {
        public static string ToUpper(string word)
        {
            string upperstr = word.ToUpper(); 
            return upperstr;
        }
        static void Main(string[] args)
        {
            // Create a progam that be able to
            // transform all string into uppercase.
            string word = Console.ReadLine();
            //string upperstr = word.ToUpper();
            string uppr = ToUpper(word); 
            Console.WriteLine(uppr);
        }
    }
}
