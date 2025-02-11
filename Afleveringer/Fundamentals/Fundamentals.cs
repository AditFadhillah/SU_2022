namespace Assignment2;
using System;

public class Fundamentals
{
    public static void CountBackwards()
    {
        for(int a=10; a>=-0;a-=1)
        {
            Console.Write(a);
            Console.Write(", ");
        }
        Console.Write("Finished! \n");
    }
    public static string ReverseString(string str)
    {  
        if (str.Length > 0)
            {
                return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1));
            }
        else
            {
                return str;
            }
    }  
    public static int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (a != 0 && b != 0)
        {
            int r = (a % b);
            while(r != 0)
            {
                a = b;
                b = r;
                r = (a % b);
            }
            return b;
        }
        if(a!=0)
        {
            return a;
        }
        return b;
    }
}