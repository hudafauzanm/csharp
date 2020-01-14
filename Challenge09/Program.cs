using System;

namespace Challange
{
    public class Timezone
    {
        public static void Main(string[] args)
        {
            var jakarta = Tuple.Create("Jakarta", 7);
            var bali = Tuple.Create("Bali", 8);
            var london = Tuple.Create("London", 0);
            var cairo = Tuple.Create("Cairo", 2);
            var denver = Tuple.Create("Denver", -6);
            var chicago = Tuple.Create("Chicago", -5);

            TimezoneDiff(jakarta, london); // Output: Jakarta 7 hours ahead London
            TimezoneDiff(cairo, chicago); // Output: Cairo 7 hours ahead Chicago
            TimezoneDiff(cairo, bali); // Output: Cairo 6 hours behind ahead Bali
            TimezoneDiff(denver, jakarta); // Output: Denver 13 hours behind Jakarta

            Console.WriteLine(TimezoneDiff(jakarta, london));
            Console.WriteLine(TimezoneDiff(cairo, chicago));
            Console.WriteLine(TimezoneDiff(cairo, bali));
            Console.WriteLine(TimezoneDiff(denver, jakarta));
            
        }

        public static string TimezoneDiff(Tuple<string, int> a, Tuple<string, int> b)
        {
            // Put your solution at here
            if (a.Item2>=b.Item2){
                 int jam1 = Math.Abs(a.Item2);
                 int jam2 = Math.Abs(b.Item2);
                 int sum = jam1 + jam2;
                 string x = a.Item1 + " " + sum + " hours ahead " + b.Item1;
                 return x;
            }
            else {
                int sum = b.Item2 - a.Item2;
                int fix = Math.Abs(sum);
                string y = a.Item1 + " " + sum + " hours behind " + b.Item1;
                return y;
            }
        }
    }
}
