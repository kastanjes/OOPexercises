using System;

class Program
{
    static void Main()
    {
        // 1. Månedsnummer gemmes i en variabel
        // Passende navn for variablen: monthNumber
        // Passende type for variablen: int
        int monthNumber = 4; // Eksempel: April

        // 2. Tjekker hvilken ferie der er i den angivne måned
        string ferieNavn;

        if (monthNumber == 10)
        {
            ferieNavn = "Efterårsferie";
        }
        else if (monthNumber == 12)
        {
            ferieNavn = "Juleferie";
        }
        else if (monthNumber == 4)
        {
            ferieNavn = "Påskeferie";
        }
        else if (monthNumber == 7 || monthNumber == 8)
        {
            ferieNavn = "Sommerferie";
        }
        else
        {
            ferieNavn = "Hårdt arbejde";
        }

        // 3. Udskriv ferie navnet eller "Hårdt arbejde"
        Console.WriteLine(ferieNavn);
    }
}
