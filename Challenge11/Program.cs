using System;

namespace Challange
{
    public class SumArguments
    {
        public static int SumArgument(int x,int y,int z,int z1)
        {
            int SUM	= 0;

		    SUM = x + y + z + z1;

            return SUM;

        }
        public static void Main(string[] args)
        {
            // Sum all args
            // You can run "dotnet run -- 1 5 8 3"
            // The output should be 17
            string input = Console.ReadLine();
            int x2 = Convert.ToInt32(input);
            string input2 = Console.ReadLine();
            int y2 = Convert.ToInt32(input2);  
            string input3 = Console.ReadLine();
            int z2 = Convert.ToInt32(input3);
            string input4 = Console.ReadLine();
            int z3 = Convert.ToInt32(input4);  

            int SUM = SumArgument(x2,y2,z2,z2);

		    Console.WriteLine(SUM);
        }
    }
}
