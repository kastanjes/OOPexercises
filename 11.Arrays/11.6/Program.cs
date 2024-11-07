using System;

class Program
{
	static void Main()
	{
		int size = 18;
		
		int[] array =  new int[size];
		
		for(int n = 0; n < array.Length; n++)
		{
			array[n] = 3 * n;
		}
		
		Console.WriteLine("Array elements in the 3-times table:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + array[i]);
        }
	}
}