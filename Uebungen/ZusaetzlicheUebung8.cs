// ReSharper disable MemberCanBePrivate.Global

namespace Programmieren_I.Uebungen;

internal static class ZusaetzlicheUebung8
{
    public static void IterationUndRekursion()
    {
        Console.WriteLine(UmdrehenIterativ("HTW Berlin"));
        Console.WriteLine(UmdrehenRekursiv("HTW Berlin"));
        CountDownIterativ(10);
        CountDownRekursiv(5);
    }

    public static string UmdrehenIterativ(string eingabe)
    {
        var result = "";
        for (var i = eingabe.Length - 1; i >= 0; i--) result += eingabe[i];

        return result;
    }

    public static void CountDownIterativ(int t)
    {
        for (var i = t; i >= 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public static string? UmdrehenRekursiv(string? eingabe)
    {
        if (eingabe is not { Length: > 1 }) return eingabe;

        return UmdrehenRekursiv(eingabe[1..]) + eingabe[0];
    }

    public static void CountDownRekursiv(int t)
    {
        if (t >= 0) return;
        Console.WriteLine(t);
        Thread.Sleep(1000);
        CountDownRekursiv(t-1);
    }
}