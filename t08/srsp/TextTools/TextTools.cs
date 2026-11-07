using System;
using System.Text;

public static class TextTools
{
    public static int CountWords(string s)
    {
        if (s == null) return 0;
        int len = s.Length;
        if (len == 0) return 0;

        int words = 0;
        bool inside = false;

        for (int i = 0; i < len; i++)
        {
            char c = s[i];
            if (c == ' ' || c == '\t' || c == '\n' || c == '\r')
            {
                inside = false;
            }
            else
            {
                if (!inside)
                {
                    words++;
                    inside = true;
                }
            }
        }
        return words;
    }

    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;

        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            char cl = s[l];
            char cr = s[r];

            if (char.IsWhiteSpace(cl))
            {
                l++;
                continue;
            }
            if (char.IsWhiteSpace(cr))
            {
                r--;
                continue;
            }

            if (char.ToLower(cl) != char.ToLower(cr))
            {
                return false;
            }

            l++;
            r--;
        }
        return true;
    }

    public static string Initials(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName)) return string.Empty;

        StringBuilder result = new StringBuilder();
        bool startNewWord = true;

        for (int i = 0; i < fullName.Length; i++)
        {
            char c = fullName[i];
            if (char.IsWhiteSpace(c))
            {
                startNewWord = true;
            }
            else
            {
                if (startNewWord)
                {
                    if (result.Length > 0)
                    {
                        result.Append(". ");
                    }
                    result.Append(char.ToUpper(c));
                    startNewWord = false;
                }
            }
        }

        if (result.Length > 0)
        {
            result.Append(".");
        }

        return result.ToString();
    }

    public static string Repeat(string s, int n)
    {
        if (string.IsNullOrEmpty(s) || n <= 0) return string.Empty;

        StringBuilder sb = new StringBuilder(s.Length * n);
        int counter = 0;
        while (counter < n)
        {
            sb.Append(s);
            counter++;
        }
        return sb.ToString();
    }
}
