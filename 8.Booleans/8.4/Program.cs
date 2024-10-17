using System;

class Program
{
	static void Main()
	{
		int dice = 3;
		bool isEvenAndGreaterThanThree = (dice % 2 == 0) && (dice > 3);
		
		Console.WriteLine(isEvenAndGreaterThanThree);
	}
}