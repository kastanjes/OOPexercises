using System;

class Program
{
    static void Main()
    {
        const int maxLimit = 1000000;
        int largestPrime = -1; // Variabel til at holde det største primtal

        // Gennemløb alle positive heltal under 1.000.000
        for (int number = 2; number < maxLimit; number++)
        {
            // Bestem om 'number' er et primtal
            if (IsPrime(number))
            {
                largestPrime = number; // Opdater det største primtal
            }
        }

        // Udskriv det største primtal
        if (largestPrime != -1)
        {
            Console.WriteLine($"Det største primtal under {maxLimit} er {largestPrime}.");
        }
    }

    // Metode til at bestemme om et givent tal er et primtal
    static bool IsPrime(int number)
    {
        // Hvis tallet er mindre end 2, så er det ikke et primtal
        if (number < 2) return false;

        // Tjekker for divisorer fra 2 til kvadratroden af 'number'
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) // Hvis der er en rest, så er det ikke et primtal
            {
                return false;
            }
        }

        return true; // Hvis ingen divisorer fandtes, så er det et primtal
    }
}
