using System;

class EMIProgram
{
    static void Main()
    {
        Console.Write("Enter Loan Amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Annual Interest Rate (%): ");
        double annualRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Loan Tenure (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        double monthlyRate = annualRate / 12 / 100;
        int months = years * 12;

        double emi = (principal * monthlyRate * Math.Pow(1 + monthlyRate, months)) /
                     (Math.Pow(1 + monthlyRate, months) - 1);

        Console.WriteLine($"\nMonthly EMI = {emi:F2}");
    }
}