// Variables are alias to memory locations.
// Before declaring a variable, we need to define its type (int, float, double, bool, char etc.)
// Variables may or may not be initialized with suitable values.
// To initialize a variable, we use the = (assignment operator).
// To use a Int64/ long variable, use L at the end of a value;
// To use a float variable, use F at the end of a value;
// To use a double variable, use D at the end of a value;
// To use a decimal variable, use M at the end of a value;  


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating and printing Integer/ INT32 variable
            int integer_number = 100;
            Console.WriteLine("The integer variable is: " + integer_number);

            // Creating and printing Long/ INT64 variable
            long long_number = 100234L;
            Console.WriteLine("The long variable is: " + long_number);

            // Creating and printing Float variable
            float float_number = 100.354F;
            Console.WriteLine("The float variable is: " + float_number);

            // Creating and printing Double variable
            double double_number = 345.2434;
            Console.WriteLine("The double variable is: " + double_number);

            // Creating and printing Decimal variable
            decimal decimal_number = 100;
            Console.WriteLine("The decimal variable is: " + decimal_number);

            // Creating and printing Boolean variable
            bool bool_varible = true;
            Console.WriteLine("The boolean variable is: " + bool_varible);

            // Creating and printing Character variable
            char char_variable = 'R';
            Console.WriteLine("The char variable is: " + char_variable);

            // Creating and printing String variable
            string string_variable = "I am a student of Uttara University";
            Console.WriteLine("The decimal variable is: " + string_variable);


            // Optional Section
            // Compare the range of Int32 and Int64.
            Console.WriteLine("The minimum Int32 value is: " + int.MinValue);
            Console.WriteLine("The maximum Int32 value is: " + int.MaxValue);
            Console.WriteLine("The minimum Int64 value is: " + long.MinValue);
            Console.WriteLine("The maximum Int64 value is: " + long.MaxValue);

            // Compare the range of float, double and decimal.
            Console.WriteLine("The minimum Float value is: " + float.MinValue);
            Console.WriteLine("The maximum Folat value is: " + float.MaxValue);
            Console.WriteLine("The minimum Double value is: " + double.MinValue);
            Console.WriteLine("The maximum Double value is: " + double.MaxValue);
            Console.WriteLine("The minimum Decimal value is: " + decimal.MinValue);
            Console.WriteLine("The maximum Decimal value is: " + decimal.MaxValue);
        }
    }
}