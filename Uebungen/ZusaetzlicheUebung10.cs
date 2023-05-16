namespace Programmieren_I.Uebungen;

public class ZusaetzlicheUebung10
{
    public static void BisektionsVerfahren()
    {
        
    }

    public static double ContinousFunction(double x)
    {
        return Math.Pow(x, 3) + x - 5;
    }

    public static double CalculateRootOfPolynomial(double a, double b)
    {
        var midPoint = double.NaN;
        var maxTolerance = Math.Pow(10, -6)
        for (var i = 1; i <= 1000; i++)
        {
            if (!(a < b)) return midPoint;
            
        }
    }
}