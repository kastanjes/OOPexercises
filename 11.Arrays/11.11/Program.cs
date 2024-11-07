using System;

public class Program
{
    public static void Main()
    {
        int limit = 1000000;
        bool[] isPrime = new bool[limit + 1];

        // Antag, at alle tal er primtal i starten
        for (int i = 2; i <= limit; i++)
        {
            isPrime[i] = true;
        }

        // Eratosthenes' si-algoritme
        for (int i = 2; i <= Math.Sqrt(limit); i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= limit; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        // Find og udskriv det største primtal under 1.000.000
        int largestPrime = 2;
        for (int i = limit; i >= 2; i--)
        {
            if (isPrime[i])
            {
                largestPrime = i;
                break;
            }
        }

        Console.WriteLine("Det største primtal under 1.000.000 er: " + largestPrime);
    }
}
