// ReSharper disable InconsistentNaming

namespace Programmieren_I.Uebungen;

public class Vektor
{
    public double X { get; set; }

    public double Y { get; set; }

    public double Z { get; set; }

    public double BerechneSkalarprodukt(Vektor b)
    {
        return X * b.X + Y * b.Y + Z * b.Z;
    }

    public static double BerechneSkalarprodukt(Vektor a, Vektor b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
    }

    public new string ToString()
    {
        return $"{X}, {Y}, {Z}";
    }
}