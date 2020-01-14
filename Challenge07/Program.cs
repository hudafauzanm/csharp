using System;

namespace Challange
{
    public class TemperatureConverter
    {
        static void Main(string[] args)
        {
            // Create a program to convert temprature unit
            CelciusToFahrenheit(0); // Output: 32
            FahrenheitToCelcius(50); // Output: 10
            CelciusToKelvin(100); // Output: 373.15
            KelvinToCelcius(375); // Output: 101.85
            KelvinToFahrenheit(375); // Output: 215.33
            FahrenheitToKelvin(12); // Output: 262.039

            Console.WriteLine("Temprature {0}",CelciusToFahrenheit(0));
            Console.WriteLine("Temprature {0}",FahrenheitToCelcius(50));
            Console.WriteLine("Temprature {0}",CelciusToKelvin(100));
            Console.WriteLine("Temprature {0}",KelvinToCelcius(375));
            Console.WriteLine("Temprature {0}",KelvinToFahrenheit(375));
            Console.WriteLine("Temprature {0}",FahrenheitToKelvin(12));
        }

        public static double CelciusToFahrenheit(double value)
        {
            double fr = (value * 9) / 5 + 32; 
            return fr;
        }

        public static double FahrenheitToCelcius(double value)
        {
            double cel = (value - 32) * 5 / 9; 
            return cel;
        }

        public static double CelciusToKelvin(double value)
        {
            double kel = value + 273.15;
            return kel;
        }

        public static double KelvinToCelcius(double value)
        {
            double cel = value - 273;
            return cel;
        }

        public static double KelvinToFahrenheit(double value)
        {
            double frh = (9.0 / 5) * (value - 273.15) + 32;
            return frh;
        }

        public static double FahrenheitToKelvin(double value)
        {
            double Kel = 273.15 + ((value - 32.0) * (5.0/9.0));
            return Kel;
        }
    }
}
