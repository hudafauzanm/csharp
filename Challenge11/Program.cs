using System;

namespace SumArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum all args
            // You can run "dotnet run -- 1 5 8 3"
            // The output should be 17
            int SUM	= 0;

		    int x = Convert.ToInt32(args[0]);
		    int y = Convert.ToInt32(args[1]);
            int z = Convert.ToInt32(args[2]);
            int z1 = Convert.ToInt32(args[3]);

		    SUM = x + y + z + z1;

		    Console.WriteLine(SUM);
        }
    }
}
