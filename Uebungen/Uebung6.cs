namespace Programmieren_I.Uebungen;
// ReSharper disable MemberCanBePrivate.Global
public static class Uebung6
{
    public static void ReihenBerechnen()
    {
        Console.WriteLine(BerechneSumme1MitEndwert(25));
        Console.WriteLine(BerechneSumme2MitEndwert(1));
        Console.WriteLine(BerechneSumme2MitEndwert(1000));
    }
    public static decimal FakultaetVon(uint number)
    {
        decimal j = 1;
        for (var i = 1; i < number + 1; i++)
        {
            j *= i;
        }

        return j;
    }

    public static decimal BerechneSumme1MitEndwert(uint endwert)
    {
        decimal result = 0;
        for (uint i = 1; i <= endwert; i++)
        {
            result += (1 / FakultaetVon(i));
        }

        return result + 1;
    }

    public static decimal BerechneSumme2MitEndwert(uint endwert)
    {
        decimal result = 0;
        for (double i = 0; i <= endwert; i++)
        {
            result += (decimal)(Math.Pow(-1.0, i) / (2.0 * i + 1.0));
        }

        return result * 4;
    }
}