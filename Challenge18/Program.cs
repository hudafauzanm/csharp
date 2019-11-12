﻿using System;

namespace FindMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};

            FindMax(numbers); // Output: 330
            FindMin(numbers); // Output: -65
            FindAverage(numbers); // Output: 52.16

            Console.WriteLine(FindMax(numbers));
            Console.WriteLine(FindMin(numbers));
            Console.WriteLine(FindAverage(numbers));
        }

        static int FindMax(int[] numbers)
        {
            int mx = numbers[0];
            int i ;
            for(i=1; i<12; i++)
            {
                if(numbers[i]>mx)
                {
                    mx = numbers[i];
                }

            }
            return mx;
        }

        static int FindMin(int[] numbers)
        {
            int mn = numbers[0];
            int i ;
            for(i=1; i<12; i++)
            {
                if(numbers[i]<mn)
                {
                    mn = numbers[i];
                }

            }
            return mn;
        }

        static decimal FindAverage(int[] numbers)
        {
        int result = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            decimal results = (decimal)result / numbers.Length;
            return results;
            
        }
    }
}
