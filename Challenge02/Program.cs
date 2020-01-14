using System;

namespace Challange
{
    public class DaysToNextBirthday
    {
        public static int difference(string inputtedDate)
        {
            var today = DateTime.Now;
            DateTime input = DateTime.Parse(inputtedDate);
            // Count the days of your next birthday
            TimeSpan difference = input - today;
            return (Convert.ToInt32(difference.Days));
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Tanggal Ulang Tahun Format:yyyy/MM/dd");
            string inputtedDate = Console.ReadLine();
            int hasil = difference(inputtedDate);
            Console.WriteLine(hasil + " days remaining to my next birthday."  );
        }
    }
}
