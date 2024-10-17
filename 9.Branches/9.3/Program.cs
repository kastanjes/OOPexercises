using System;

class Program
{
	static void Main()
	{
		int antalSekunderSidenNytår = 21816000;
		double pris = 599.95;
		
		const int secondsPerMinute = 60;
        const int minutesPerHour = 60;
        const int hoursPerDay = 24;
        const int daysPerMonth = 30;

        long totalDaysSinceNewYears = antalSekunderSidenNytår / (secondsPerMinute * minutesPerHour * hoursPerDay);
		
		int month = (int)(totalDaysSinceNewYears / daysPerMonth) + 1; 
        int day = (int)(totalDaysSinceNewYears % daysPerMonth) + 1;
			
		if(month == 12 && day == 24)
		{
			double tilbudsPris = pris * 0.70;
			Console.WriteLine("Der gives 30% rabat da det er jul! Prisen er nu " + tilbudsPris + " dkk.");
		}
		else 
		{
			Console.WriteLine("Det er ikke jul og derfor er der ikke tilbud. Prisen er " + pris + " dkk.");
		}
	}
}