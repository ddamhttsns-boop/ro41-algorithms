using System;

public static class ArrayAlgos
{
    public static bool IsSorted(int[] a)
    {
        if (a == null || a.Length <= 1) return true;
        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] > a[i + 1]) return false;
        }
        return true;
    }

    public static int BubbleSort(int[] a)
    {
        if (a == null || a.Length <= 1) return 0;
        int comps = 0;
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                comps++;
                if (a[j] > a[j + 1])
                {
                    int tmp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = tmp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
        return comps;
    }

    public static int CountOccurrences(int[] sortedA, int x)
    {
        if (sortedA == null || sortedA.Length == 0) return 0;
        int lb = GetLowerBound(sortedA, x);
        int ub = GetUpperBound(sortedA, x);
        return ub - lb;
    }

    private static int GetLowerBound(int[] arr, int target)
    {
        int l = 0, r = arr.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (arr[m] >= target) r = m;
            else l = m + 1;
        }
        return l;
    }

    private static int GetUpperBound(int[] arr, int target)
    {
        int l = 0, r = arr.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (arr[m] > target) r = m;
            else l = m + 1;
        }
        return l;
    }
}
