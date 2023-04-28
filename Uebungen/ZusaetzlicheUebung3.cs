using System.Globalization;

namespace Programmieren_I.Uebungen;

public static class ZusaetzlicheUebung3
{
    public static void AusgabeAlsBinärUndHexadezimalZahl()
    {
        Console.WriteLine("Bitte geben Sie eine Zahl zwischen 0 und 255 ein:");
        var eingabe = Console.ReadLine();
        if (!byte.TryParse(eingabe, out var zahl)) Console.WriteLine("Die Eingabe ist ungültig");
        Console.WriteLine(Byte2Binary(zahl));
        Console.WriteLine(Byte2Hexadecimal(zahl));
    }

    private static string Byte2Binary(byte number)
    {
        var i = 0;
        var result = "";

        while (i < 8)
        {
            if (number % 2 != 0)
                result += "1";
            else
                result += "0";
            number = (byte)(number / 2);
            i++;
        }

        return Reverse(result);
    }

    private static string Byte2Hexadecimal(byte number)
    {
        var i = 0;
        var result = "";

        while (i < 2)
        {
            if (number % 16 != 0)
            {
                var dNumber = number / 16.0;
                var bNumber = number / 16;
                result += HexNum((dNumber - bNumber) * 16);
            }
            else
            {
                result += "0";
            }

            number = (byte)(number / 16);
            i++;
        }

        return Reverse(result);
    }

    private static string Reverse(string s)
    {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    private static string HexNum(double decnum)
    {
        return decnum switch
        {
            10 => "A",
            11 => "B",
            12 => "C",
            13 => "D",
            14 => "E",
            15 => "F",
            _ => decnum.ToString(CultureInfo.InvariantCulture)
        };
    }
}