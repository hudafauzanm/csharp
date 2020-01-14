using System;

namespace Challange
{
    public class GradeClass
    {   
        public static string Grade(int testScore)
        {
            if (testScore >= 90)
                    {
                        string A = "A";
                        return A;
                    }
                    else if (testScore >= 80)

                    {
                        string B = "B";
                        return B;
                    }
                    else if (testScore >= 70)

                    {
                        string C = "C";
                        return C;
                    }
                    else if (testScore >= 60)

                    {
                        string D = "D";
                        return D;
                    }
                    else
                    {
                        string E = "E";
                        return E;
                    }

        }
        static void Main(string[] args)
        {
            // Create a method called Grade()
            // That method should accept an integer with some criteria
            // 1) If the input equal or more than 90 the output will be "A"
            // 2) If the input within range 80 to 89 the output will be "B"
            // 3) If the input within range 70 to 79 the output will be "C"
            // 4) If the input within range 60 to 69 the output will be "D"
            // 5) If the input below 59 the output will be "E"
            
            string input = Console.ReadLine();
            int testScore = Convert.ToInt32(input);
            string hasil = Grade(testScore);

            Console.WriteLine("Score",Grade(40));
        }
    }
}
