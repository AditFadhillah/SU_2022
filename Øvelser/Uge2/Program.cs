namespace test;
using System;

// class text
// {
//     public static int TestPred(int x)
//     {
//         Console.WriteLine("Boris was here");
//         return 10;
//     }
//     public static void Main(string[] args)
//     {
//         int a=11;
//         int b=10;
//         if (TestPred(a) && TestPred(b))
//         {
//             Console.WriteLine("True");
//         }

//     }
// }

// class text
// {
//     public static int TestIntGenerator(int x)
//     {
//         Console.WriteLine("Boris was here");
//         return 10;
//     }
//     public static void Main(string[] args)
//     {
//         int a=11;
//         switch(a)
//         {
//             default : Console.WriteLine("Default case hit");
//                         break;
//             case 10 : Console.WriteLine("case 10");
//                         break;
//             case 11 : Console.WriteLine("case 11");
//                         break;
//         }
//     }
// }

// class text
// {
//     public static int TestIntGenerator(int x)
//     {
//         Console.WriteLine("Boris was here");
//         return 10;
//     }
//     public static void Main(string[] args)
//     {
//         int a=1;
//         while(a < 5)
//         {
//             Console.WriteLine("Hello");
//             a = a+1;
//         }
//     }
// }

// class text
// {
//     public static int TestIntGenerator(int x)
//     {
//         Console.WriteLine("Boris was here");
//         return 10;
//     }
//     public static void Main(string[] args)
//     {
//         for(int a=0; a<=10;a+=2)
//         {
//             Console.WriteLine(a);
//         }
//     }
// }

// class text
// {
//     public static int TestIntGenerator(int x)
//     {
//         Console.WriteLine("Boris was here");
//         return 10;
//     }
//     public static void Main(string[] args)
//     {
//         for(int a=10; a>=0;a-=2)
//         {
//             Console.WriteLine(a);
//         }
//     }
// }

// class text
// {
//     public static int TestIntGenerator(int x)
//     {
//         Console.WriteLine("Boris was here");
//         return 10;
//     }
//     public static void Main(string[] args)
//     {
//         int[] myArray= new int[10];

//         for(int a=0; a<10;a++)
//         {
//             myArray[a]=a;
//             Console.WriteLine(a);
//         }
//     }
// }

class text
{
    public static int TestIntGenerator(int x)
    {
        Console.WriteLine("Boris was here");
        return 10;
    }
    public static void Main(string[] args)
    {
        const int arrayLength=10;
        int[] myArray= new int[arrayLength];

        for(int a=0; a<myArray.Length;a++)
        {
            myArray[a]=5*a;
            Console.WriteLine(myArray);
        }
    }
}