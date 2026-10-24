using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое неотрицательное число n:");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int n) || n < 0)
        {
            Console.WriteLine("Ошибка: некорректный ввод. Требуется целое число >= 0.");
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
            int temp = n;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit;
                count++;
                temp /= 10;
            }
        }

        Console.WriteLine($"Количество цифр: {count}");
        Console.WriteLine($"Сумма цифр: {sum}");
    }
}
