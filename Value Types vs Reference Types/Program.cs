using System;

//ref link:https://www.youtube.com/watch?v=0CsRK1HzJWk&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=7
// stack - low room vs heap - high room storage
// semantics of change between ref/class vs struct/value types


//class Fraction    // reference type
struct Fraction     // value type
{
    public int numerator;
    public int denominator;
}

class MainClass
{
    static void Main()
    {
        Fraction fract1 =
            new Fraction
            {
                numerator = 1,
                denominator = 2
            };
        Fraction fract2 = fract1;
        fract2.numerator = 555;
        Console.WriteLine(fract1.numerator);    // class output:1   struct output:555
        Console.WriteLine(fract2.numerator);    // class output:555 struct output:555

    }
}