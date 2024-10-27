using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Fraction b = new Fraction(3);
        Fraction c = new Fraction(7, 3);
        Console.WriteLine(a.GetFractionString());
        Console.WriteLine(a.GetDecimalValue());
        Console.WriteLine(b.GetFractionString());
        Console.WriteLine(b.GetDecimalValue());
        Console.WriteLine(c.GetFractionString());
        Console.WriteLine(c.GetDecimalValue());
    }
}