using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called Grade()
            // That method should accept an integer with some criteria
            // 1) If the input equal or more than 90 the output will be "A"
            // 2) If the input within range 80 to 89 the output will be "B"
            // 3) If the input within range 70 to 79 the output will be "C"
            // 4) If the input within range 60 to 69 the output will be "D"
            // 5) If the input below 59 the output will be "E"
            
            int Grade(int testScore)
            {
                if (testScore >= 90)
                    {
                        Console.WriteLine("A");
                        return 0;
                    }
                    else if (testScore >= 80)

                    {
                        Console.WriteLine("B");
                        return 0;
                    }
                    else if (testScore >= 70)

                    {
                        Console.WriteLine("C");
                        return 0;
                    }
                    else if (testScore >= 60)

                    {
                        Console.WriteLine("D");
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("F");
                        return 0;
                    }
            }

            Console.WriteLine("Score",Grade(40));
        }
    }
}
