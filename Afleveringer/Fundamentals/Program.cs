namespace Assignment2;
using System;

public class text
{
    public static void Main(string[] args)
    {
        Fundamentals.CountBackwards();
        Console.WriteLine(Fundamentals.ReverseString("stressed :("));
        Console.WriteLine(Fundamentals.GCD(0,0));
        Console.WriteLine(Fundamentals.GCD(0,10));
        Console.WriteLine(Fundamentals.GCD(10,0));
        Console.WriteLine(Fundamentals.GCD(13,37));
        Console.WriteLine(Fundamentals.GCD(-99,4345));
    }
}