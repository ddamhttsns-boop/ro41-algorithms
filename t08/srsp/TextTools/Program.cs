using System;

class Program
{
    static void Main()
    {
        RunCheck("CountWords", "", 0, TextTools.CountWords(""));
        RunCheck("CountWords", "    ", 0, TextTools.CountWords("    "));
        RunCheck("CountWords", " a  b ", 2, TextTools.CountWords(" a  b "));
        RunCheck("IsPalindrome", "А роза упала на лапу Азора", true, TextTools.IsPalindrome("А роза упала на лапу Азора"));
        RunCheck("IsPalindrome", "тест", false, TextTools.IsPalindrome("тест"));
        RunCheck("Initials", "Ахметов Ерлан Серикұлы", "А. Е. С.", TextTools.Initials("Ахметов Ерлан Серикұлы"));
        RunCheck("Initials", "Ахметов Ерлан", "А. Е.", TextTools.Initials("Ахметов Ерлан"));
        RunCheck("Repeat", "abc", 3, "abcabcabc", TextTools.Repeat("abc", 3));
    }

    static void RunCheck(string label, object input, object expected, object actual)
    {
        string status = (expected != null && expected.Equals(actual)) ? "OK" : "FAIL";
        Console.WriteLine($"{label} | In: \"{input}\" | Expected: {expected} | Actual: {actual} | Status: {status}");
    }
}
