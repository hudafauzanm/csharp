using System;

namespace Challange
{
    public class Sorter
    {
        public static int[] hasil(int[] points)
        {
            Array.Sort(points);
            return points;
        }
        public static void Main(string[] args)
        {
            // Create sorted numbers of points
            int[] points = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
            // Array.Sort(points);
            var hasil2 = hasil(points);
            foreach (int i in hasil2){
                Console.WriteLine(i + " ");
            }
        }
    }
}
