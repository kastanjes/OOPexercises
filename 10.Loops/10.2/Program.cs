using System;

class Program
{
	static void Main()
	{
		double celsiusStart = 40;
		double celsiusSlut = -5;
		double step = 0.5;
		
		Console.WriteLine("Celsius\t\tFahrenheit");
        Console.WriteLine("------------------------");

		for(double celsius = celsiusStart; celsius >= celsiusSlut; celsius -= step)
		{
			double fahrenheit = 32 + (9.0 / 5.0) * celsius;
			Console.WriteLine($"{celsius:F1}\t\t{fahrenheit:F1}");
		}
	}
}
	