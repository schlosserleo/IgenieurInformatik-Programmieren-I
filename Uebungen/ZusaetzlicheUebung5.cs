using System.Numerics;

namespace Programmieren_I.Uebungen;

public static class ZusaetzlicheUebung5
{
    public static void Fakultaet()
    {
        Console.WriteLine(CalculateFactorial(7).ToString());
    }

    public static BigInteger CalculateFactorial(uint number)
    {
        var j = 1;
         for (var i = 1; i < number +1; i++)
         {
             j *= i;
         }

         return j;
    }
}