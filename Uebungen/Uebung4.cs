// ReSharper disable MemberCanBePrivate.Global

namespace Programmieren_I.Uebungen;

internal static class Uebung4
{
    public static void MathematischeFunktionen()
    {
        Mul(Add(1, 2), Sub(42, 1));
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Sub(int a, int b)
    {
        return a - b;
    }

    public static int Mul(int a, int b)
    {
        return a * b;
    }

    public static int Div(int a, int b)
    {
        return a / b;
    }

    public static uint Mod(uint a, uint b)
    {
        return a % b;
    }

    public static bool IsEven(uint x)
    {
        return Mod(x, 2) == 0;
    }
}