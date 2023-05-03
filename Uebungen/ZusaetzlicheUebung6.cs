// ReSharper disable MemberCanBePrivate.Global
namespace Programmieren_I.Uebungen;

public static class ZusaetzlicheUebung6
{
    public static void NewtonVerfahren()
    {
        Console.WriteLine(CalculateRootOfPolynomial(0));
    }

    public static double ContinousFunction(double x)
    {
        return Math.Pow(x, 3) - x - 2;
    }

    public static double DerivativeOfContinousFunction(double x)
    {
        return 3 * Math.Pow(x, 2) - 1;
    }

    public static double CalculateRootOfPolynomial(double x0)
    {
        var xn = x0;
        var i = 0;
        double cancelReq = 1;
        while (i <= 100 && cancelReq > Math.Pow(10, -6))
        {
            var div = ContinousFunction(xn) / DerivativeOfContinousFunction(xn);
            cancelReq = Math.Abs(div);
            xn -= div;
            i++;
        }
        return xn;
    }
}