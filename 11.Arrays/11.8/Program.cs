using System;

class Program
{
	static void Main()
	{
		int[] cirkler = {1,3,5};
		
		for(int i = 0; i < cirkler.Length; i++)
		{
			double areal = Math.PI * Math.Pow(cirkler[i], 2);
			Console.WriteLine("Arealet af en cirkel med radius " + cirkler[i] + " er lig " + areal.ToString("F2"));
		}
	}
}