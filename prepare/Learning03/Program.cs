using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction value1 = new Fraction();
        Console.WriteLine(value1.GetFractionString());
        Console.WriteLine(value1.GetDecimalValue());

        Fraction value2 = new Fraction(5);
        Console.WriteLine(value2.GetFractionString());
        Console.WriteLine(value2.GetDecimalValue());

        Fraction value3 = new Fraction(3, 4);
        Console.WriteLine(value3.GetFractionString());
        Console.WriteLine(value3.GetDecimalValue());

        Fraction value4 = new Fraction(1, 3);
        Console.WriteLine(value4.GetFractionString());
        Console.WriteLine(value4.GetDecimalValue());
    }
}