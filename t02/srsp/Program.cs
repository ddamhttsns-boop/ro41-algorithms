using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое неотрицательное число n: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int n))
        {
            Console.WriteLine("Ошибка: введено не целое число!");
            return;
        }

        if (n < 0)
        {
            Console.WriteLine("Ошибка: число должно быть неотрицательным (n >= 0).");
            return;
        }

        int count = 0;
        int sum = 0;

        if (n == 0)
        {
            count = 1;
            sum = 0;
        }
        else
        {
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;
                count++;
                n /= 10;
            }
        }

        Console.WriteLine($"Количество цифр (count): {count}");
        Console.WriteLine($"Сумма цифр (sum): {sum}");
    }
}
