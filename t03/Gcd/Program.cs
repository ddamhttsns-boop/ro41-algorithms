using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        if (!int.TryParse(Console.ReadLine(), out int a) || a < 0) return;

        Console.Write("Введите b: ");
        if (!int.TryParse(Console.ReadLine(), out int b) || b < 0) return;

        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }

        Console.WriteLine($"НОД: {a}");
    }
}
