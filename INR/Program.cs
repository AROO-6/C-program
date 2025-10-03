using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter Amount in INR: ");
        double inr = Convert.ToDouble(Console.ReadLine());

        double usdRate = 0.012;  // Example: 1 INR = 0.012 USD
        double eurRate = 0.011;  // Example: 1 INR = 0.011 EUR
        double gbpRate = 0.0095; // Example: 1 INR = 0.0095 GBP

        double usd = inr * usdRate;
        double eur = inr * eurRate;
        double gbp = inr * gbpRate;

        Console.WriteLine($"\n{inr} INR = {usd:F2} USD");
        Console.WriteLine($"{inr} INR = {eur:F2} EUR");
        Console.WriteLine($"{inr} INR = {gbp:F2} GBP");
    }
}