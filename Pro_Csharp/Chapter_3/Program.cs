// using System;
// namespace SimpleCSharpApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Display a simple message to the user.
//             Console.WriteLine("***** My First C# App *****");
//             Console.WriteLine("Hello World!");
//             Console.WriteLine();

//             // Wait for Enter key to be pressed before shutting down.
//             Console.ReadLine();
//         }
//     }
// }

// --------------------------------------------------------------------------------------------------------------
// using System;
// // Display a simple message to the user.
// Console.WriteLine("***** My First C# App *****");
// Console.WriteLine("Hello World!");
// Console.WriteLine();
// // Wait for Enter key to be pressed before shutting down.
// Console.ReadLine();

// // Note we are explicitly returning an int, rather than void.
// // Display a message and wait for Enter key to be pressed.
// Console.WriteLine("***** My First C# App *****");
// Console.WriteLine("Hello World!");
// Console.WriteLine();
// Console.ReadLine();
// // Return an arbitrary error code.
// return -1;

// --------------------------------------------------------------------------------------------------------------
// using System;
// namespace SimpleCSharpApp
// {
//     class Program
//     {
//         static int Main(string[] args)
//         {
//             // Display a simple message to the user.
//             Console.WriteLine("***** My First C# App *****");
//             Console.WriteLine("Hello World!");
//             Console.WriteLine();

//             // Wait for Enter key to be pressed before shutting down.
//             Console.ReadLine();
//             return -1;
//         }
//     }
// }

// --------------------------------------------------------------------------------------------------------------
// // Display a message and wait for Enter key to be pressed.
// Console.WriteLine("***** My First C# App *****");
// Console.WriteLine("Hello World!");
// Console.WriteLine();
// // Process any incoming args.
// for (int i = 0; i < args.Length; i++)
// {
// Console.WriteLine("Arg: {0}", args[i]);
// }
// Console.ReadLine();
// // Return an arbitrary error code.
// return 0;

// --------------------------------------------------------------------------------------------------------------
// // Notice you have no need to check the size of the array when using "foreach".
// // Process any incoming args using foreach.
// // Display a message and wait for Enter key to be pressed.
// Console.WriteLine("***** My First C# App *****");
// Console.WriteLine("Hello World!");
// Console.WriteLine();
// foreach(string arg in args)
// {
//     Console.WriteLine("Arg: {0}", arg);
// }
// Console.ReadLine();
// return 0;

// --------------------------------------------------------------------------------------------------------------
// using System;


// namespace SimpleCSharpApp
// {
//     class Program
//     {
//         ShowEnvironmentDetails();
//         static int Main(string[] args)
//         {
//             // Display a simple message to the user.
//             Console.WriteLine("***** My First C# App *****");
//             Console.WriteLine("Hello World!");
//             Console.WriteLine();


//             // Wait for Enter key to be pressed before shutting down.
//             Console.ReadLine();
//             return -1;
//         }
//     }
// }

// --------------------------------------------------------------------------------------------------------------
// namespace test
// {
//     class test1
//     {
//         static void Main(string[] args)
//         {
//             // Get name and age.
//             Console.WriteLine("Please enter your name: ");
//             string userName = Console.ReadLine();
//             Console.WriteLine("Please enter your age: ");
//             string userAge = Console.ReadLine();
//             // Change echo color, just for fun.
//             ConsoleColor prevColor = Console.ForegroundColor;
//             Console.ForegroundColor = ConsoleColor.Yellow;
//             // Echo to the console.
//             Console.WriteLine("Hello {0}! You are {1} years old.",
//             userName, userAge);
//             // Restore previous color.
//             Console.ForegroundColor = prevColor;
//             }
//         } 
//     }

// --------------------------------------------------------------------------------------------------------------
// using System;
// Console.WriteLine("***** Basic Console I/O *****");
// GetUserData();
// Console.ReadLine();
// static void GetUserData()
// {
//     // Get name and age.
//     Console.Write("Please enter your name: ");
//     string userName = Console.ReadLine();
//     Console.Write("Please enter your age: ");
//     string userAge = Console.ReadLine();
//     // Change echo color, just for fun.
//     ConsoleColor prevColor = Console.ForegroundColor;
//     Console.ForegroundColor = ConsoleColor.Yellow;
//     // Echo to the console.
//     Console.WriteLine("Hello {0}! You are {1} years old.",
//     userName, userAge);
//     // Restore previous color.
//     Console.ForegroundColor = prevColor;
// }

using System;
Console.WriteLine("***** Basic Console I/O *****");
Numbers();
Console.ReadLine();
static void Numbers()
{
    // John says...
    Console.WriteLine("{0}, Number {0}, Number {0}", 9);
    // Prints: 20, 10, 30
    Console.WriteLine("{1}, {0}, {2}", 10, 20, 30);
}
