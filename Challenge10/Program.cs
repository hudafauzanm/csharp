using System;

namespace Challange
{
    public class Calculator
    {
        public static int Sum(int a,int b)
        {
            int sum = a + b ;
            return sum;
        } 
        public static int Substract(int a,int b)
        {
            int subs = a - b ;
            return subs;
        }

        public static int Multiply(int a,int b)
        {
            int mult = a*b;
            return mult;
        }

        public static int Divide(int a,int b)
        {
            int div = a/b ;
            return div;
        }

        static void Main(string[] args)
        {
            // Create methods called Sum, Substract, Multiply, Divide
            // Each methods should accept two parameters number
            // and also return a number.
            // Example:
            // Sum(1, 6) // Output: 7
            string input = Console.ReadLine();
            int a = Convert.ToInt32(input);
            string input2 = Console.ReadLine();
            int b = Convert.ToInt32(input2);  

            int hasil = Sum(a,b);        

            Console.WriteLine(hasil);
        }
    }
}
