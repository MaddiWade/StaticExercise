using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var celcius = TempConverter.FarenheitToCelsius(56);
            Console.WriteLine(celcius);

            var fahrenheit = TempConverter.CelsiusToFahrenheit(28);
            Console.WriteLine(fahrenheit);
        }

    }

}