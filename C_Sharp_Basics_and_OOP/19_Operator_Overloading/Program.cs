// Overloading operators means expanding the usability of the various
// arithmetic, logical, comparison and other operators, so we can perform 
// operations on custom data like classes.
// For example, by overloading the + operator, we can add two objects directly
// Similarly, we can overload other mathematical operators like -, *, /, %, ++,--
// Interestingly, by overloading +, we automatically overload +=
// Similar is the case for the rest of the mathematical operators
// But you can not overload the && (AND) and || (OR) operators
// Find more about which operators you can or can not overload in your provided study material
// The syntax to overload an operator is:
// public static return_type operator operator_symbol(parameters)
// Here, return_type is usually the data that we get after performing said operation
// 'static' keyword is particularly important, operator overloading methods must always be static methods
// so that we can use them without creating instances of that class.
// operator symbol is the operator we want to overload
// parameters can be objects of the same class or other data types
// Below are examples of a few arithmetic, logical and comparison operators


using System;
using System.Numerics;
namespace OperatorOverloading{
    class App{
        public static void Main(string[] args){
            ComplexNumber c1 = new ComplexNumber(1, 2);
            ComplexNumber c2 = new ComplexNumber(5, 7);

            // using overloaded + to add two objects
            ComplexNumber c3 = c1 + c2;

            // using overloaded + to add an object and an integer
            ComplexNumber c4 = c1 + 2;

            // demonstration of += being automatically overloaded by overloading +
            ComplexNumber c5 = new ComplexNumber(0, 3);
            c5 += 2;

            // using overloaded -- to decrease field values.
            c5--;

            c1.displayComplex();
            c2.displayComplex();
            c3.displayComplex();
            c4.displayComplex();
            c5.displayComplex();

            // using overloaded == and != to check if two objects are equal
            Console.WriteLine("c1 == c2: " + (c1 == c2));
            Console.WriteLine("c1 != c2: " + (c1 != c2));

            // using overloaded < and > to check which object is greater
            Console.WriteLine("c3 > c4: " + (c3 > c4));
            Console.WriteLine("c3 < c4: " + (c3 < c4));
        }
    }

    class ComplexNumber{
        public int real;
        public int imaginary;

        public ComplexNumber(int real, int imaginary){
            this.real = real;
            this.imaginary = imaginary;
        }

        public void displayComplex(){
            Console.WriteLine($"{real} + {imaginary}i");
        }

        // overloading + to add 2 objects, returns an object
        public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2){
            int newReal = c1.real + c2.real;
            int newImaginary = c1.imaginary + c2.imaginary;

            ComplexNumber c3 = new ComplexNumber(newReal, newImaginary);
            return c3;
        }

        // overloading + to add an integer to the object fields, retuns an object
        public static ComplexNumber operator + (ComplexNumber c1, int x){
            int newReal = c1.real + x;
            int newImaginary = c1.imaginary + x;

            ComplexNumber c3 = new ComplexNumber(newReal, newImaginary);
            return c3;
        }

        // overloading -- to decrease the value of an object by 1, returns an object
        public static ComplexNumber operator -- (ComplexNumber c1){
            int newReal = c1.real--;
            int newImaginary = c1.imaginary--;

            ComplexNumber c3 = new ComplexNumber(newReal, newImaginary);
            return c3;
        }

        // overloading == and != to check if two objects are the same, returns true or false
        // == and != must always be overloaded in pair, otherwise this generates an error
        public static bool operator == (ComplexNumber c1, ComplexNumber c2){
            bool isRealEqual = c1.real == c2.real;
            bool isImaginaryEqual = c1.imaginary == c2.imaginary;
            return isRealEqual && isImaginaryEqual;
        }
        public static bool operator != (ComplexNumber c1, ComplexNumber c2){
            return !(c1 == c2);
        }

        // overloading the > and < operators to check if object c1 is greater or less than c2, returns true or false
        // > and < must always be overloaded in pair
        public static bool operator > (ComplexNumber c1, ComplexNumber c2){
            bool isRealGreater = c1.real > c2.real;
            bool isImaginaryGreater = c1.imaginary > c2.imaginary;
            return isRealGreater && isImaginaryGreater;
        } 

        public static bool operator < (ComplexNumber c1, ComplexNumber c2){
            return !(c1 > c2);
        }
    }
}