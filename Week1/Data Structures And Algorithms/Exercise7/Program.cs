using System;

public class FinancialForecast
{
    // Step 2 & 3: Recursive method to calculate future value
    public static double CalculateFutureValue(double principal, double rate, int years)
    {
        if (years == 0)
            return principal;

        return CalculateFutureValue(principal, rate, years - 1) * (1 + rate);
    }

    // Optimized version using memoization
    public static double CalculateFutureValueMemo(double principal, double rate, int years, double[] memo)
    {
        if (years == 0)
            return principal;

        if (memo[years] != 0)
            return memo[years];

        memo[years] = CalculateFutureValueMemo(principal, rate, years - 1, memo) * (1 + rate);
        return memo[years];
    }

    public static void Main(string[] args)
    {
        double principal = 1000;     // Initial investment
        double growthRate = 0.10;    // Annual growth rate (10%)
        int forecastYears = 5;       // Forecast duration in years

        Console.WriteLine("Future Value using Recursive Method:");
        double futureValue = CalculateFutureValue(principal, growthRate, forecastYears);
        Console.WriteLine($"Future value after {forecastYears} years: ₹{futureValue:F2}");

        Console.WriteLine("\nFuture Value using Optimized Memoization:");
        double[] memo = new double[forecastYears + 1];
        double futureValueOptimized = CalculateFutureValueMemo(principal, growthRate, forecastYears, memo);
        Console.WriteLine($"Future value after {forecastYears} years: ₹{futureValueOptimized:F2}");
    }
}
