using System;

namespace FooBarBaz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a loop from 1 to 1000.
            // Each loop should print out a number.
            // But, there is some criteria:
            // 1) When the number multiplied by 5, the output will change like so "5. Foo".
            // 2) When the number multiplied by 20, the output will change like so "40. Bar".
            // 3) When the number multiplied by 100, the output will change like so "300. Baz".
            int i;
            for (i=1 ; i<=1000 ; i++)
            {
                if (i%100==0){
                    Console.WriteLine(i+"."+" "+"Baz");
                }
                else if (i%20==0){
                    Console.WriteLine(i+"."+" "+"Bar");
                }
                else if(i%5==0){
                    Console.WriteLine(i+"."+" "+"Foo");
                }
                else
                    Console.WriteLine(i+".");
            }
        }
    }
}
