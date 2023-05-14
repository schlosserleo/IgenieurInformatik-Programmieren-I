// ReSharper disable PropertyCanBeMadeInitOnly.Global

namespace Programmieren_I.Uebungen;

public class Punkt
{
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

    public override string ToString()
    {
        return $"{X}, {Y}, {Z}";
    }
}