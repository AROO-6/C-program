using System;
class EMI
{
    static void main()
    {
        Console.WriteLine("enter loan amount");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter amount intrest rate(%):");
        double annualrate=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter loan year");
        int years=Convert.ToInt32(Console.ReadLine());
        double monthrate = annualrate / (12 * 100);
        int months = years * 12;
        double emi = (principal * monthrate * Math.Pow(1 + monthrate, months)) / (Math.Pow(1 + monthrate, months) - 1);
        Console.WriteLine("\nmonthly EMI=" + emi.ToString("0.00"));

    }
}