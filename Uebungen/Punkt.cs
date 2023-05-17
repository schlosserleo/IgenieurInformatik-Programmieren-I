// ReSharper disable PropertyCanBeMadeInitOnly.Global

namespace Programmieren_I.Uebungen;

public class Punkt
{
    public Punkt(double x = 0, double y = 0, double z = 0)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double X { get; set; }

    public double Y { get; set; }

    public double Z { get; set; }

    public double AbstandZu(Punkt endPunkt)
    {
        var deltaX = X - endPunkt.X;
        var deltaY = Y - endPunkt.Y;
        var deltaZ = Z - endPunkt.Z;
        return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
    }

    public static double AbstandZwischen(Punkt startPunkt, Punkt endPunkt)
    {
        var deltaX = startPunkt.X - endPunkt.X;
        var deltaY = startPunkt.Y - endPunkt.Y;
        var deltaZ = startPunkt.Z - endPunkt.Z;
        return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
    }

    public Vektor BildeVektor(Punkt endPunkt)
    {
        var deltaX = endPunkt.X - X;
        var deltaY = endPunkt.Y - Y;
        var deltaZ = endPunkt.Z - Z;
        return new Vektor(deltaX, deltaY, deltaZ);
    }

    public static Vektor BildeVektor(Punkt startPunkt, Punkt endPunkt)
    {
        var deltaX = endPunkt.X - startPunkt.X;
        var deltaY = endPunkt.Y - startPunkt.Y;
        var deltaZ = endPunkt.Z - startPunkt.Z;
        return new Vektor(deltaX, deltaY, deltaZ);
    }

    public Vektor AlsVektor()
    {
        return new Vektor(X, Y, Z);
    }

    public override string ToString()
    {
        return $"{X}, {Y}, {Z}";
    }
}