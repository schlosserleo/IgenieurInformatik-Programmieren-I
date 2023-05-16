// ReSharper disable MemberCanBePrivate.Global
namespace Programmieren_I.Uebungen;

public static class ZusaetzlicheUebung10
{
    public static void BisektionsVerfahren()
    {
        Console.WriteLine(CalculateRootOfPolynomial(-4, 4));
    }
    
    public static double ContinousFunction(double x)
    {
        return Math.Pow(x, 3) + x - 5;
    }

    public static double CalculateRootOfPolynomial(double a, double b)
    {
        var midPoint = double.NaN;
        var tolerance = Math.Pow(10, -6);
        for (var i = 1; i <= 1000; i++)
        {
            if (!(a < b)) return midPoint;
            if (!((ContinousFunction(a) < 0 && ContinousFunction(b) > 0) ||
                  (ContinousFunction(a) > 0 && ContinousFunction(b) < 0))) return midPoint;
            midPoint = (a + b) / 2.0;
            if (ContinousFunction(midPoint) == 0.0 || b - a < tolerance) return midPoint;
            if (Math.Sign(ContinousFunction(midPoint)) == Math.Sign(ContinousFunction(a)))
                a = midPoint;
            else
                b = midPoint;
        }

        return midPoint;
    }
}