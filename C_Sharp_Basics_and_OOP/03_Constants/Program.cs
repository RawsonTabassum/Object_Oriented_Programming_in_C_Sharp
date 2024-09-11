// Constants are values that remain unchanged throughout the code.
// Take for example, the value of PI = 3.14 or the value of graviational acceleration g = 9.8
// If we change the values of PI, it may lead to incorrect output.
// Your student ID or registration number is also a property that should stay constant throughout your student life.
// Declaring constants is similar to declaring variables, just add the keyword 'const' as a prefix.
// Syntax: const data_type variable_name = value;
// Example: const float g = 9.8;


using System;
using System.Net.NetworkInformation;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;   // declared a const.
            double radius = 4;
            double areaOfCircle = PI * radius * radius;

            Console.WriteLine("The area of the circle is: " + areaOfCircle);
        }
    }
}
