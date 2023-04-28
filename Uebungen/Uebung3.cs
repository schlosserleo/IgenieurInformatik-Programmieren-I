using System.Globalization;

// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable ConvertToConstant.Local

namespace Programmieren_I.Uebungen;

internal static class Uebung3
{
    public static void Typen()
    {
        uint a0 = 100101101;
        float a1 = 1.0f;
        string a2 = "HTW Berlin";
        double a3 = 299.0 * 1e6;
        char a4 = '#';
        int a5 = -1234;
        byte a6 = 123;
        bool a7 = true;
        decimal a8 = -11111.1m;
        ushort a9 = 65535;

        int b0 = 0;
        double b1 = 1.0;
        float b2 = 2f;
        string b3 = "3";

        // ReSharper disable once UselessBinaryOperation
        var c0 = b0 * (int)b1;
        double c1 = double.Parse(b3);
        float c2 = (float)b1 + b2;
        string c3 = b1.ToString(CultureInfo.InvariantCulture);

        GebeVariableAus(nameof(a0), a0);
        GebeVariableAus(nameof(a1), a1);
        GebeVariableAus(nameof(a2), a2);
        GebeVariableAus(nameof(a3), a3);
        GebeVariableAus(nameof(a4), a4);
        GebeVariableAus(nameof(a5), a5);
        GebeVariableAus(nameof(a6), a6);
        GebeVariableAus(nameof(a7), a7);
        GebeVariableAus(nameof(a8), a8);
        GebeVariableAus(nameof(a9), a9);

        GebeVariableAus(nameof(c0), c0);
        GebeVariableAus(nameof(c1), c1);
        GebeVariableAus(nameof(c2), c2);
        GebeVariableAus(nameof(c3), c3);

        Console.WriteLine(InStunden(90) + "h");
    }

    private static void GebeVariableAus(string name, object wert)
    {
        Console.WriteLine($"Die Variable {name} ist vom Typ {wert.GetType()} und hat den Wert {wert}");
    }

    // Rechnet Minuten in Stunden um. Z.B: 90 min => 1.5h
    // ReSharper disable once MemberCanBePrivate.Global
    public static double InStunden(int minuten)
    {
        double stunden = (double)minuten / 60;
        return stunden;
    }
}