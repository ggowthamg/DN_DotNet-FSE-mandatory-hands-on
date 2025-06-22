using System;

class Program
{
    static void Main()
    {
        double presentValue = 1000;  // Example: ₹1000 starting amount
        double growthRate = 0.05;    // Example: 5% growth per year
        int years = 5;               // Example: Forecast for 5 years

        double futureValue = CalculateFutureValue(presentValue, growthRate, years);
        Console.WriteLine($"Future value after {years} years = {futureValue:C2}");
    }

    static double CalculateFutureValue(double presentValue, double rate, int years)
    {
        if (years == 0)
            return presentValue;
        return CalculateFutureValue(presentValue * (1 + rate), rate, years - 1);
    }
}
