using System;

class Program
{
    static void Main()
    {
        // 1. Antal sekunder siden 1. januar gemmes i en variabel
        long secondsSinceNewYear = 31449600; // For eksempel, et tidsstempel

        // Konstanter
        const int secondsPerMinute = 60;
        const int minutesPerHour = 60;
        const int hoursPerDay = 24;
        const int daysPerMonth = 30;
        const int daysPerYear = 365;

        // 2. Konverter sekunder til antal dage
        long totalDays = secondsSinceNewYear / (secondsPerMinute * minutesPerHour * hoursPerDay);

        // 3. Beregn hvilken måned og dag det er
        int month = (int)(totalDays / daysPerMonth) + 1; // +1 for at starte månedsnummer fra 1
        int day = (int)(totalDays % daysPerMonth) + 1;   // +1 for at starte dagen fra 1

        // Udskriv måned og dag
        Console.WriteLine($"Måned: {month}");
        Console.WriteLine($"Dag: {day}");

        // 4. Tjek om det er jul (24. december)
        if (month == 12 && day == 24)
        {
            Console.WriteLine("Det er jul!");
        }
        else
        {
            Console.WriteLine("Det er ikke jul.");
        }
    }
}
