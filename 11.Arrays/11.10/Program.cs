using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Indtast månedsnummer (1-12): ");
        int month = int.Parse(Console.ReadLine());

        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (month >= 1 && month <= 12)
        {
            int days = daysInMonth[month - 1];
            Console.WriteLine($"Måned {month} har {days} dage.");
        }
        else
        {
            Console.WriteLine("Ugyldigt månedsnummer.");
        }
    }
}
