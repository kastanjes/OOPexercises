using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to hold the Celsius values
        List<double> celsiusValues = new List<double>();
        
        // Generate Celsius values from 40 to -5 with a step of 0.5
        for (double celsius = 40; celsius >= -5; celsius -= 0.5)
        {
            celsiusValues.Add(celsius);
        }
        
        // Output the header
        Console.WriteLine("Celsius\t\tFahrenheit");
        Console.WriteLine("------------------------");

        // Use a foreach loop to iterate over the Celsius values
        foreach (double celsius in celsiusValues)
        {
            double fahrenheit = 32 + (9.0 / 5.0) * celsius;
            Console.WriteLine($"{celsius:F1}\t\t{fahrenheit:F1}");
        }
    }
}
