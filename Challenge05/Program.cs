using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new method with ability to detect odd or even number.
            // Example:
            // IsOdd(4) // false
            // IsEven(8) // true

            int IsEven(int S)
            {
                if(S%2 == 0){
                Console.WriteLine("True");
                return 0;
                }
                else{
                    Console.WriteLine("False");
                return 0;
                }
            }
            
            int IsOdd(int S)
            {
                if(S%2 == 1){
                    Console.WriteLine("True");
                return 0;
                }
                else{
                    Console.WriteLine("False");
                return 0;
                }
                
            }

            Console.WriteLine("IsOdd(4)",IsOdd(4));
            Console.WriteLine("IsEven(8)",IsEven(8));
        }
    }
}
