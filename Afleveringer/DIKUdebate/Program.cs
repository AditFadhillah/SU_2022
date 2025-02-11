namespace DIKUdebate;
using System;

public class Program
{
    public static void Main(string[] args)
    {
            Classroom class1 = new Classroom();
            DIKUperson Anders = new DIKUperson ("Anders", DIKUPreparation.ReadingSome);
            DIKUperson Braum = new DIKUperson ("Braum", DIKUPreparation.ReadingAll);
            Console.WriteLine(Anders);
            Console.WriteLine(Braum);
            class1.Discussion(Anders, Braum);
            class1.Discussion(Anders, Braum);
            Console.WriteLine(Anders);
            Console.WriteLine(Braum);
    }
}