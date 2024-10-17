using System;

class Program
{
    static void Main()
    {
        // 1. Månedsnummer gemmes i en variabel
        // Passende navn for variablen: monthNumber
        // Passende type for variablen: int
        int monthNumber = 2; // Eksempel: Februar

        // 2. Array til at holde antallet af dage i hver måned
        int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Tjek om månedsnummeret er gyldigt
        if (monthNumber < 1 || monthNumber > 12)
        {
            Console.WriteLine("Ugyldigt månedsnummer. Vælg mellem 1 og 12.");
            return; // Afslutter programmet tidligt
        }

        // 3. Bestem antal dage i den måned
        int daysInMonth = daysInMonths[monthNumber - 1]; // -1 for at få den rigtige indeks

        // 4. Udskriv antallet af dage i den pågældende måned
        Console.WriteLine($"Månedsnummer {monthNumber} har {daysInMonth} dage.");
    }
}
