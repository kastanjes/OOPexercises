using System;

class TemperatureTable
{
    static void Main()
    {
        // Start- og sluttemperatur i Celsius
        double startCelsius = -5.0;
        double endCelsius = 40.0;
        double step = 0.5;

        Console.WriteLine("Celsius\t\tFahrenheit");
        Console.WriteLine("------------------------");

        // Løkke for at gå igennem temperaturerne i trin på 0,5°C
        for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
        {
            // Fahrenheit beregning
            double fahrenheit = 32 + (9.0 / 5.0) * celsius;
            
            // Udskriv Celsius og Fahrenheit i tabelformat
            Console.WriteLine($"{celsius:F1}\t\t{fahrenheit:F1}");
        }
    }
}
