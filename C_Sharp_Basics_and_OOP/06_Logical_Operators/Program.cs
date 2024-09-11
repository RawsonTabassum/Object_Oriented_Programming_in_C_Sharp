// The logical operators supported by C# are &&(AND), ||(OR), and !(NOT)
// Some comparison operators that produce boolean resuls are <, >, ==, <=, >= and !=
// C# also supports some bitwise operators
// &(bitwise-AND), |(bitwise-OR), ~(bitwise-NOT), << (left-shift), >> (right-shift) and >>> (unsigned right shift)
// The following code skips the code example of the bitwise operators.

// Logical operators are only applicable on boolean values and the resutl is also a boolean value.
// Comparison operators can be applied on any data type and the result will be boolean value.

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            bool b = true;

            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!b);

            int x = 10, y = 15, z = 10;
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x == z);
            Console.WriteLine(x != y);
            Console.WriteLine(y >= z);
            Console.WriteLine(y <= z);
        }
    }
}
