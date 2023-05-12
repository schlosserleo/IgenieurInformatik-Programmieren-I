// ReSharper disable MemberCanBePrivate.Global
namespace Programmieren_I.Uebungen;

public static class Uebung9
{
    public static void MethodenParameter()
    {
        var text1 = "Halloo";
        var text2 = "Hallo";
        Console.WriteLine($"Text 1: '{text1}' \nText 2: '{text2} ");
        Sort(ref text1, ref text2);
        Console.WriteLine($"Text 1: '{text1}' \nText 2: '{text2} ");
        GetCurrentDate(out var day, out var month, out var year);
        Console.WriteLine($"{day}, {month}, {year}");
        //GetCurrentDate2(12, 05, 2023);
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
        if (text1.Length > text2.Length)
        {
            (text1, text2) = (text2, text1);
        }

        return true;
    }
}