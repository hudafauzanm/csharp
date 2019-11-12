using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create methods called Sum, Substract, Multiply, Divide
            // Each methods should accept two parameters number
            // and also return a number.
            // Example:
            // Sum(1, 6) // Output: 7

            int Sum (int a,int b){
                int sum = a + b ;
                return sum;
            }
            int Substract ( int a,int b)
            {
                int subs = a - b ;
                return subs;
            }
            int Multiply (int a, int b)
            {
                int mult = a*b;
                return mult;
            }
            int Divide ( int a,int b)
            {
                int div = a/b ;
                return div;
            }

            Console.WriteLine("Penjumlahan hasil = {0}",Sum(1,6));
        }
    }
}
