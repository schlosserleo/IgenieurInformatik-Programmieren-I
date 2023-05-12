// ReSharper disable MemberCanBePrivate.Global
namespace Programmieren_I.Uebungen;

public static class Uebung9
{
    public static void MethodenParameter()
    {
        var text1 = "Hochschule für Technik und Wirtschaft";
        var text2 = "HTW Berlin";
        Console.WriteLine($"Text 1: '{text1}' \nText 2: '{text2} ");
        if (Sort(ref text1, ref text2))
            Console.WriteLine($"Text 1: '{text1}' \nText 2: '{text2} ");
        GetCurrentDate(out var day, out var month, out var year);
        Console.WriteLine($"{day}, {month}, {year}");
    }
    
    public static void GetCurrentDate(out int day, out int month, out int year)
    {
        day = DateTime.Now.Day;
        month = DateTime.Now.Month;
        year = DateTime.Now.Year;
    }
    
    public static bool Sort(ref string text1, ref string text2)
    {
        if (text1 == "" || text2 == "") return false;
        if (string.Compare(text1, text2, StringComparison.InvariantCulture) > 0)
        {
            (text1, text2) = (text2, text1);
        }
        return true;
    }
}