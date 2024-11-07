using System;

class Program
{
	static void Main()
	{
		double celsiusStart = 40;
        double celsiusSlut = -5;
        double step = 0.5;
        double celsius = celsiusStart;
		
		Console.WriteLine("Celsius\t\tFahrenheit");
        Console.WriteLine("------------------------");
		
		do
		{
			double fahrenheit = 32 + (9.0 / 5.0) * celsius;
            Console.WriteLine($"{celsius:F1}\t\t{fahrenheit:F1}");
            celsius -= step; // Opdaterer værdien af celsius
		}
		while (celsius >= celsiusSlut);
	}
}
