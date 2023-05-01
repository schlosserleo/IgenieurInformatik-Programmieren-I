using System.Numerics;

// ReSharper disable MemberCanBePrivate.Global

namespace Programmieren_I.Uebungen;

public static class ZusaetzlicheUebung5
{
    public static void Fakultaet()
    {
        Console.WriteLine(CalculateFactorial(20));
        Console.WriteLine(CalculateBigFactorial(60));
    }

    public static long CalculateFactorial(uint number)
    {
        long j = 1;
        for (var i = 1; i < number + 1; i++)
        {
            checked
            {
                j *= i;
            }
        }
        return j;
    }

    public static BigInteger CalculateBigFactorial(uint number)
    {
        BigInteger j = 1;
        for (var i = 1; i < number + 1; i++)
        {
            j *= i;
        }

        return j;
    }
}