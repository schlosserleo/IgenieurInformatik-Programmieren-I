// ReSharper disable InconsistentNaming
namespace Programmieren_I.Uebungen;

public class Vektor
{
    private double x;
    private double y;
    private double z;
    public double X
    {
        get => x;
        set => x = value;
    }

    public double Y
    {
        get => y;
        set => y = value;
    }

    public double Z
    {
        get => z;
        set => z = value;
    }

    public double BerechneSkalarprodukt(Vektor b)
    {
        return x * b.X + y * b.Y + z * b.Z;
    }

    public static double BerechneSkalarprodukt(Vektor a, Vektor b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
    }
    
}