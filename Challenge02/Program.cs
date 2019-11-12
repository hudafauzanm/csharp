using System;

namespace DaysToNextBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Tanggal Ulang Tahun Format:yyyy/MM/dd");
            DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
            var today = DateTime.Now;
            // Count the days of your next birthday
            TimeSpan difference = inputtedDate - today;
            Console.WriteLine(difference.Days + " days remaining to my next birthday."  );
        }
    }
}
