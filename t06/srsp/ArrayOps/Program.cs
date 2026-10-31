
using System;

static class ArrayOps
{
    public static int Sum(int[] a)
    {
        int result = 0;

        for (int i = 0; i < a.Length; i++)
        {
            result += a[i];
        }

        return result;
    }

    public static int IndexOfMin(int[] a)
    {
        int minIndex = 0;

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < a[minIndex])
            {
                minIndex = i;
            }
        }

        return minIndex;
    }

    public static int CountGreater(int[] a, int x)
    {
        int result = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > x)
            {
                result++;
            }
        }

        return result;
    }

    public static void Reverse(int[] a)
    {
        for (int i = 0; i < a.Length / 2; i++)
        {
            int lastIndex = a.Length - 1 - i;

            int saved = a[i];
            a[i] = a[lastIndex];
            a[lastIndex] = saved;
        }
    }
}

class Program
{
    static void PrintArray(int[] a)
    {
        Console.Write("[ ");

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]);

            if (i < a.Length - 1)
                Console.Write(", ");
        }

        Console.WriteLine(" ]");
    }

    static void Main()
    {
        int[][] tests =
        {
            new int[] { 4, 1, 7, 3, 9 },
            new int[] { 5 },
            new int[] { -2, -7, -4 },
            new int[] { 2, 2, 2 }
        };

        int testNumber = 1;

        foreach (int[] numbers in tests)
        {
            Console.WriteLine("Тест №" + testNumber);

            Console.Write("Исходный массив: ");
            PrintArray(numbers);

            Console.WriteLine("Сумма: " + ArrayOps.Sum(numbers));
            Console.WriteLine("Индекс минимума: " + ArrayOps.IndexOfMin(numbers));
            Console.WriteLine("Чисел больше 2: " + ArrayOps.CountGreater(numbers, 2));

            ArrayOps.Reverse(numbers);

            Console.Write("Обратный массив: ");
            PrintArray(numbers);

            Console.WriteLine();
            testNumber++;
        }
    }
}
