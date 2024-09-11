// This is the basic structure of a C# program
// System is a namespace. 
// using system; imports the namespace and you can now access the classes in the System namespace
// Program is a class which contains the Main() function
// The Main() function is the starting point of a C# program. A C# program can only have one Main() function.
// Console.WriteLine() is the output function. Here Console is a class of the System namespace.
// Console.WriteLine() will display any variable, string and every other data types.
// A C# program can have multiple namespaces and classes.
// Each namespace and class scope is surrounded by {}. Necessary codes are written within {} blocks.


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}