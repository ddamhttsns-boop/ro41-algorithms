using System;

static class Rec
{
    public static int DigitSum(int n)
    {
        if (n == 0)
            return 0;

        return n % 10 + DigitSum(n / 10);
    }

    public static long Pow(int x, int n)
    {
        if (n == 0)
            return 1;

        if (n == 1)
            return x;

        return x * Pow(x, n - 1);
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 0, 7, 12345, 1000 };

        foreach (int number in numbers)
            Console.WriteLine($"DigitSum({number}) = {Rec.DigitSum(number)}");

        int[,] powers = { { 2, 0 }, { 2, 10 }, { 5, 3 }, { 7, 1 } };

        for (int i = 0; i < powers.GetLength(0); i++)
        {
            int x = powers[i, 0];
            int n = powers[i, 1];

            Console.WriteLine($"Pow({x}, {n}) = {Rec.Pow(x, n)}");
        }
    }
}