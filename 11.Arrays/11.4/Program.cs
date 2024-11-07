using System;

class Program
{
	static void Main()
	{
		
		int[] array = {12, 45, 67, 89, 34, 23, 89, 56 };
		int størsteTal = array[0];
		int indeksTal = 0;
			
			for(int i = 1; i < array.Length; i++)
			{
				if(array[i] > størsteTal)
				{
					størsteTal = array[i];
					indeksTal = i;
				}
			}
		
		Console.WriteLine("Det største tal er: " + størsteTal);
        Console.WriteLine("Indekset for det største tal er: " + indeksTal);
	}
}