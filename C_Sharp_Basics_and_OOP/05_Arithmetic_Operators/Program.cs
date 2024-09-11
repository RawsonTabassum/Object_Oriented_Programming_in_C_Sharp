// Arithmetic Operators are +(addition), -(subtraction), *(multiplication), /(division) and %(remainder)
// These operators can be applied on all the numerical data types available in C#.
// Maintain caution when using the division '/' operator since the program crashes if the denominator is 0.
// Example: 5/0 is infinity and the program can not calculate it.
// Adding the same data types do not change the data type of the result.
// However, it is possible to perform arithmetic operations between an integer or long value and a double or float value. 
// The data type of the result is determined using data type precedence if no type casting is used.
// So,
// integer + long = long
// integer + float = float
// integer + double = double
// integer + decimal = decimal
// long + float = float
// long + double = double
// long + decimal = decimal
// float + double = double
// You can not perform any arithmetic operations between a double and a decimal type.
// The % opeator will always return an integer value.



using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            long b = 20L;
            float c = 12.34F;
            double d = 56.78D;
            decimal e = 123.34M;

            // Change the + operator and put -, *, / and % to check the data types of the results.
            Console.WriteLine((a+b) + ", "+ (a+b).GetType());
            Console.WriteLine((a+c) + ", "+ (a+c).GetType());
            Console.WriteLine((a+d) + ", "+ (a+d).GetType());
            Console.WriteLine((a+e) + ", "+ (a+e).GetType());
            Console.WriteLine((b+c) + ", "+ (b+c).GetType());
            Console.WriteLine((b+d) + ", "+ (b+d).GetType());
            Console.WriteLine((c+d) + ", "+ (c+d).GetType());

            // Sometimes the division operation of two integers result into a double value.
            // Example 5/3 = 1.66666666667.
            // In such cases, if the result is saved into an integer variable, the output will only show
            // the decimal portion of the result (in this case, 5/3 = 1)
            int result1 = 5/3;
            Console.WriteLine("Before implicit casting, 5/3 = " + result1 + ", " + result1.GetType());

            // In this case, to preserve the value after the decimal point, we can change the datatype
            // of the result and use implicit type castnig.

            // implicit type casting:
            double result2 = (double) 5/3;
            Console.WriteLine("After implicit casting, 5/3 = " + result2 + ", " + result2.GetType());
        }
    }
}