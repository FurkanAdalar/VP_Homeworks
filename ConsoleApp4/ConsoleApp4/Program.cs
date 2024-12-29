using System;

public class Program
{
    public static void Main(string[] args)
    {
        int a = 2;
        int b = 3;
        int add = 0;
        int mult = 0;

        AddOrMult(a, b, ref add, ref mult);
        Console.WriteLine(add);  // 5
        Console.WriteLine(mult); // 6
    }

    private static void AddOrMult(int a, int b, ref int add, ref int mult)
    {
        add = a + b;
        mult = a * b;
    }
}
