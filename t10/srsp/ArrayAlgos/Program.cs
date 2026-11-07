using System;

class Program
{
    static void Main()
    {
        RunTest(new int[] { });
        RunTest(new int[] { 5 });
        RunTest(new int[] { 1, 2, 3, 4, 5 });
        RunTest(new int[] { 5, 4, 3, 2, 1 });
        RunTest(new int[] { 3, 1, 3, 2, 3 });

        int[] big = new int[1000];
        for (int i = 0; i < 1000; i++) big[i] = i + 1;
        int c = ArrayAlgos.BubbleSort(big);
        Console.WriteLine($"1000 elements comps: {c}");

        int[] arr = { 1, 2, 2, 2, 5, 7 };
        int[] targets = { 2, 1, 7, 3, 9 };
        foreach (var t in targets)
        {
            Console.WriteLine($"Count {t}: {ArrayAlgos.CountOccurrences(arr, t)}");
        }
    }

    static void RunTest(int[] org)
    {
        int[] clone = (int[])org.Clone();
        int comps = ArrayAlgos.BubbleSort(clone);
        bool sorted = ArrayAlgos.IsSorted(clone);
        Console.WriteLine($"Before: [{string.Join(", ", org)}] | After: [{string.Join(", ", clone)}] | Sorted: {sorted} | Comps: {comps}");
    }
}
