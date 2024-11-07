using System;

class Program
{
	static void Main()
	{
		double[] temperaturer = {21.5,23.7,19.6,22.5,25.3,21.7,18.9};
		
		for(int i = 1; i < temperaturer.Length; i++)
		{
			double differens = temperaturer[i] - temperaturer[i-1];
			Console.WriteLine(differens);
		}
	}
}