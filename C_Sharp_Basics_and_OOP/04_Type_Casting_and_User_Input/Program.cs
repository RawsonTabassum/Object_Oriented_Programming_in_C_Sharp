// Type casting means converting one variable type into another.
// Type casting is exceptionally important while taking input.
// The Console.ReadLine() function accepts input as a string
// because it reads user input from the console as a sequence of characters.

// That is why even when we type in numbers, they are considered as strings 
// and we need type casting to convert the input back to out desired form.

// Available Functions to convert to certain data types:
// Convert.ToInt32() converts to integer
// Convert.ToInt64() converts to long
// Convert.ToSingle() converts to float
// Convert.ToDouble() converts to double
// Convert.ToDecimal() converts to decimal
// Convert.ToChar() converts to character
// Convert.ToString() converts to string

// To convert a user input to any desired data type, we pass the Console.ReadLine() function
// to the necessary conversion function.

// Permitted conversions
// Any data type can be converted to a string
// a single digit or a single-character string can be converted to character
// a string can be converted to integer or long if the string contains only numbers
// a string can be converted to a float, double or decimal if the string contains only numbers or numbers with a radix point (Ex: 1.234)
// a string can be converted to a boolean if the string says "true" or "false".


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taking only numbers as user input and converting to integer
            int integer_input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The data type of the user input is: " + integer_input.GetType());

            // Taking only numbers as user input and converting to long
            long long_input = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("The data type of the user input is: " + long_input.GetType());

            // Taking numbers with a radix point as user input and converting to float
            float float_input = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("The data type of the user input is: " + float_input.GetType());

            // Taking numbers with a radix point as user input and converting to double
            double double_input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The data type of the user input is: " + double_input.GetType());

            // Taking numbers with a radix point as user input and converting to decimal
            decimal decimal_input = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The data type of the user input is: " + decimal_input.GetType());

            // Taking only "true" or "false" as user input and converting to boolean
            bool boolean_input = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("The data type of the user input is: " + boolean_input.GetType());

            // Taking a single character as user input and converting to char
            char char_input = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("The data type of the user input is: " + char_input.GetType());


            // Casting every other type to string:
            string case1 = Convert.ToString(1000);
            string case2 = Convert.ToString(345.2341);
            string case3 = Convert.ToString(true);
            string case4 = Convert.ToString('G');
            Console.WriteLine("Case 1: " + 1000.GetType() + " is converted into " + case1.GetType());
            Console.WriteLine("Case 2: " + 345.2341.GetType() + " is converted into " + case2.GetType());
            Console.WriteLine("Case 3: " + true.GetType() + " is converted into " + case3.GetType());
            Console.WriteLine("Case 4: " + 'G'.GetType() + " is converted into " + case4.GetType());
        }
    }
}