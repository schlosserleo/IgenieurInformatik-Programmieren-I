// ReSharper disable MemberCanBePrivate.Global

namespace Programmieren_I.Uebungen;

internal static class ZusaetzlicheUebung7
{
    public static void TextanalyseMitCollections()
    {
        var dict = ErmittleBuchstabenVerteilung("Hochschule für Technik und Wirtschaft");
        foreach (var i in dict) Console.WriteLine(i);
        Console.WriteLine(
            $"Der Häufigste Buchstabe ist {ErmittleMaxKey(dict)} und kommt {ErmittleMaxValue(dict)} mal vor");
    }

    public static Dictionary<char, int> ErmittleBuchstabenVerteilung(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (var i in s.Where(char.IsLetter))
            if (!dict.TryAdd(i, 1))
                dict[i]++;

        return dict;
    }

    public static int ErmittleMaxValue(Dictionary<char, int> dict)
    {
        return dict.Values.Max();
    }

    public static char ErmittleMaxKey(Dictionary<char, int> dict)
    {
        // return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key; <-- Das habe ich aus dem Internet kopiert(Funktioniert auch)
        return dict.FirstOrDefault(x => x.Value == ErmittleMaxValue(dict)).Key;
    }
}