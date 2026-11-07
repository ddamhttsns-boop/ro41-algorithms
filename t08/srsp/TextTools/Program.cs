using System;

class Program
{
    static void Main()
    {
        Check("CountWords", "", 0, TextTools.CountWords(""));
        Check("CountWords", "    ", 0, TextTools.CountWords("    "));
        Check("CountWords", " a  b ", 2, TextTools.CountWords(" a  b "));

        Check("IsPalindrome", "А роза упала на лапу Азора", true, TextTools.IsPalindrome("А роза упала на лапу Азора"));
        Check("IsPalindrome", "тест", false, TextTools.IsPalindrome("тест"));

        Check("Initials", "Ахметов Ерлан Серикұлы", "А. Е. С.", TextTools.Initials("Ахметов Ерлан Серикұлы"));
        Check("Initials", "Ахметов Ерлан", "А. Е.", TextTools.Initials("Ахметов Ерлан"));

        Check("Repeat", "abc", 3, "abcabcabc", TextTools.Repeat("abc", 3));
    }

    static void Check(string name, object input, object expected, object actual)
    {
        string res = (expected != null && expected.Equals(actual)) ? "OK" : "FAIL";
        Console.WriteLine($"{name} | In: \"{input}\" | Exp: {expected} | Act: {actual} | {res}");
    }
}
