using System;

class Program
{
    static void Main()
    {
        int count = 0;
        int sum = 0;
        int fives = 0;

        int grade = Grades.Read();
        while (grade != Grades.Stop)
        {
            if (Grades.IsValid(grade))
            {
                count++;
                sum += grade;
                if (grade == Grades.Max)
                {
                    fives++;
                }
            }
            grade = Grades.Read();
        }

        Grades.PrintStats(count, sum, fives);
    }
}

static class Grades
{
    public const int Min = 2;
    public const int Max = 5;
    public const int Stop = 0;

    public static int Read()
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        return -1;
    }

    public static bool IsValid(int g)
    {
        return g >= Min && g <= Max;
    }

    public static void PrintStats(int count, int sum, int fives)
    {
        if (count == 0)
        {
            Console.WriteLine("Оценок нет");
        }
        else
        {
            double average = (double)sum / count;
            Console.WriteLine($"Количество оценок: {count}");
            Console.WriteLine($"Сумма оценок: {sum}");
            Console.WriteLine($"Количество пятерок: {fives}");
            Console.WriteLine($"Средний балл: {average:F2}");
        }
    }
}
