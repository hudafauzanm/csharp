using System;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            CountWords("Hello"); // Output: 1
            CountWords("Hello World"); // Output: 2
            CountWords("Lorem ipsum dolor sit amet"); // Output: 5

            Console.WriteLine(CountWords("Hello"));
            Console.WriteLine(CountWords("Hello World"));
            Console.WriteLine(CountWords("Lorem ipsum dolor sit amet"));
        }

        static int CountWords(string value)
        {
            // Make this method to be able counting words
            int a = 0;
            int myWord = 1;
            while (a <= value.Length - 1) {
                if(value[a]==' ' || value[a]=='\n' || value[a]=='\t') {
             myWord++;
             }
             a++;
             }
             return myWord;
        }
    }
}
