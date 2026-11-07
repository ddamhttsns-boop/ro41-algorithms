using System;
using System.Text;

public static class TextTools
{
    public static int CountWords(string text)
    {
        if (string.IsNullOrEmpty(text)) return 0;
        int counter = 0, state = 0;
        for (int k = 0; k < text.Length; k++)
        {
            if (char.IsWhiteSpace(text[k]))
            {
                state = 0;
            }
            else if (state == 0)
            {
                state = 1;
                counter++;
            }
        }
        return counter;
    }

    public static bool IsPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text)) return true;
        int a = 0, b = text.Length - 1;
        while (a < b)
        {
            while (a < b && char.IsWhiteSpace(text[a])) a++;
            while (a < b && char.IsWhiteSpace(text[b])) b--;
            if (char.ToLower(text[a]) != char.ToLower(text[b])) return false;
            a++;
            b--;
        }
        return true;
    }

    public static string Initials(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return string.Empty;
        StringBuilder sb = new StringBuilder();
        bool flag = true;
        for (int i = 0; i < name.Length; i++)
        {
            if (char.IsWhiteSpace(name[i]))
            {
                flag = true;
            }
            else if (flag)
            {
                if (sb.Length > 0) sb.Append(". ");
                sb.Append(char.ToUpper(name[i]));
                flag = false;
            }
        }
        if (sb.Length > 0) sb.Append(".");
        return sb.ToString();
    }

    public static string Repeat(string source, int times)
    {
        if (string.IsNullOrEmpty(source) || times <= 0) return string.Empty;
        StringBuilder builder = new StringBuilder();
        int index = 0;
        while (index < times)
        {
            builder.Append(source);
            index++;
        }
        return builder.ToString();
    }
}
