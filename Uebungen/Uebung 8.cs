// ReSharper disable MemberCanBePrivate.Global

using System.Globalization;

namespace Programmieren_I.Uebungen;

internal enum Wochentag
{
    Sonntag,
    Montag,
    Dienstag,
    Mittwoch,
    Donnerstag,
    Freitag,
    Samstag
}

internal enum MonatGregorianisch
{
    Januar = 1,
    Februar = 2,
    März = 3,
    April = 4,
    Mai = 5,
    Juni = 6,
    Juli = 7,
    August = 8,
    September = 9,
    Oktober = 10,
    November = 11,
    Dezember = 12
}

internal enum MonatJulianisch
{
    Januar = 11,
    Februar = 12,
    März = 1,
    April = 2,
    Mai = 3,
    Juni = 4,
    Juli = 5,
    August = 6,
    September = 7,
    Oktober = 8,
    November = 9,
    Dezember = 10
}

internal static class Uebung8
{
    public static void DatumBestimmen()
    {
        var dates = new[] { "01.03.2007", "07.06.2018", "08.06.2018", "29.05.2019", "09.05.2023" };
        foreach (var i in dates)
        {
            Console.WriteLine(IstGueltigesDatum(i));
            var dateArray = ErmittleTagMonatJahr(i);
            if (dateArray == null) return;
            var tag = dateArray[0];
            var monat = dateArray[1];
            var jahr = dateArray[2];
            Console.WriteLine(ErmittleWochentag(tag, monat, jahr));
        }
    }

    public static bool IstGueltigesDatum(string datum)
    {
        return DateTime.TryParseExact(datum, "dd.MM.yyyy", new CultureInfo("de-DE"),
            DateTimeStyles.None, out _);
    }

    public static int[]? ErmittleTagMonatJahr(string datum)
    {
        if (!DateTime.TryParseExact(datum, "dd.MM.yyyy", new CultureInfo("de-DE"),
                DateTimeStyles.None, out var validDate)) return null;
        var day = validDate.Day;
        var month = validDate.Month;
        var year = validDate.Year;
        Console.WriteLine($"{day.ToString()}, {month.ToString()}, {year.ToString()}");
        return new[] { day, month, year };
    }

    private static int Modulo(double a, int b)
    {
        if (a < 0)
            return (int)(a % b + b);
        return (int)a % b;
    }

    public static Wochentag ErmittleWochentag(int tag, int monat, int jahr)
    {
        double y;
        double c;
        if (monat < 3)
        {
            y = int.Parse((jahr - 1).ToString()[2..]);
            c = int.Parse((jahr - 1).ToString()[..2]);
        }
        else
        {
            y = int.Parse(jahr.ToString()[2..]);
            c = int.Parse(jahr.ToString()[..2]);
        }

        var d = (double)tag;
        //var m = (double)((monat + 10) % 12);
        var gregMonth = (MonatGregorianisch)monat;
        var m = Enum.Parse<MonatJulianisch>(gregMonth.ToString());
        var w = Modulo(d + (2.6 * m. - 0.2) + y + (int)(y / 4) + (int)(c / 4) - 2 * c, 7);
        return (Wochentag)w;
    }
}