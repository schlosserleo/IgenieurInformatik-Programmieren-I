// ReSharper disable MemberCanBePrivate.Global

namespace Programmieren_I.Uebungen;

internal static class Uebung7
{
    public static void Textanalyse()
    {
        Console.WriteLine(ZaehleZahlen(" 12 und 3 und 34 aber 3 4 5 78347 "));
        Console.WriteLine(ErmittleHaeufigstenBuchstaben("Hallooo"));
    }

    public static int ZaehleZahlen(string s)
    {
        var count = 0;
        var prev = false;
        foreach (var i in s)
        {
            if (char.IsDigit(i) && !prev)
                count++;

            prev = char.IsDigit(i);
        }

        return count;
    }

    public static char ErmittleHaeufigstenBuchstaben(string s)
    {
        var charCount = new int[255];
        foreach (var i in s.Where(char.IsLetter)) charCount[i]++;

        var highestValue = charCount.Max();
        var highestIndex = Array.IndexOf(charCount, highestValue);
        return (char)highestIndex;
    }
}