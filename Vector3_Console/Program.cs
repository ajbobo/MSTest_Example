using System;

namespace MSTest_Example;

public class ConsoleApp
{
    public static void Main(string[] args)
    {
        Vector3 v = new Vector3 { X = 1, Y = 2, Z = 3 };
        Console.WriteLine($"V = {v}");

        Vector3 v2 = new Vector3 { X = 2, Y = 2, Z = 2 };
        Console.WriteLine($"V + V2 = {v.Add(v2)}");
    }
}
