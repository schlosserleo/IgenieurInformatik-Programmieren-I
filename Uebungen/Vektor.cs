// ReSharper disable PropertyCanBeMadeInitOnly.Global

namespace Programmieren_I.Uebungen;

public class Vektor
{
    private double _tempX;
    private double _tempY;
    private double _tempZ;

    public Vektor(double x = 0, double y = 0, double z = 0)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double X { get; set; }

    public double Y { get; set; }

    public double Z { get; set; }

    private void SetTempVars()
    {
        _tempX = X;
        _tempY = Y;
        _tempZ = Z;
    }

    public Vektor Addiere(params Vektor[] summanden)
    {
        SetTempVars();

        foreach (var i in summanden)
        {
            _tempX += i.X;
            _tempY += i.Y;
            _tempZ += i.Z;
        }

        return new Vektor(_tempX, _tempY, _tempZ);
    }

    public Vektor Subtrahiere(params Vektor[] subtrahenden)
    {
        SetTempVars();
        foreach (var i in subtrahenden)
        {
            _tempX -= i.X;
            _tempY -= i.Y;
            _tempZ -= i.Z;
        }

        return new Vektor(_tempX, _tempY, _tempZ);
    }

    public Vektor MultipliziereSkalar(double skalarfaktor)
    {
        SetTempVars();

        _tempX *= skalarfaktor;
        _tempY *= skalarfaktor;
        _tempZ *= skalarfaktor;

        return new Vektor(_tempX, _tempY, _tempZ);
    }

    public Vektor BildeKreuzprodukt(Vektor b)
    {
        SetTempVars();

        _tempX = Y * b.Z - Z * b.Y;
        _tempY = Z * b.X - X * b.Z;
        _tempZ = X * b.Y - Y * b.X;

        return new Vektor(_tempX, _tempY, _tempZ);
    }

    public double BerechneSkalarprodukt(Vektor b)
    {
        return X * b.X + Y * b.Y + Z * b.Z;
    }

    public static double BerechneSkalarprodukt(Vektor a, Vektor b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
    }

    public Punkt AlsPunkt()
    {
        return new Punkt(X, Y, Z);
    }

    public override string ToString()
    {
        return $"{X}, {Y}, {Z}";
    }
}