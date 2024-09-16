// methods are a block of code written under an identity
// The goals of using methods is to reuse codes.
// You can declare methods inside a class.
// Methods can be static or non-static.

// The basic structure of a non-static method is:
// access_modifier return_type method_name (parameters list)
// The basic structure of a static method is:
// access_modifier static return_type method_name (parameters list)

// return type can be any of the avaiable data types. If a method returns nothing, we write void
// access modifiers can be public, private, protected or internal.
// method names follow the same naming conventions as variables
// parameters list is a list of data the method receives.
// We invoke a method by calling it. Once a method is called, it performs the instruction written under it.
// If the method returns a data, we can store it in a similar variable. 
// say a method returns the sum of two integers, so we can store the result in an int variable.


using System;

namespace MyApp
{
    internal class Program
    {
        // return type void with no parameters
        public static void sayHello(){
            Console.WriteLine("Hello World");
        }

        // return type void with string parameters.
        public static void formName(string fName, string lName){
            Console.WriteLine("Username = " + fName + " " + lName);
        }

        // return type int with int parameters
        public static int addNumbers(int a, int b){
            return a + b;
        }

        // return type double with int parameters
        public static double findAverage(int a, int b, int c){
            int total = a + b + c;
            double average = (double) total / 3;     // this is an example of implicit type casting
            return average;
        }

        // return type string with int parameters
        public static string isPrime(int a){
            for(int i=2; i<Math.Sqrt(a); i++){
                if(a % i == 0){
                    return "Not Prime";
                }
            }
            return "Prime";
        }

        // return type int with string parameter
        public static int countVowels(string str){
            int vowelCount = 0;
            str = str.ToUpper();
            for(int i=0; i<str.Length; i++){
                if (str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U'){
                    vowelCount++;
                }
            }
            return vowelCount;
        }

        // Now try writing some methods on your own.

        static void Main(string[] args)
        {
            // Calling methods.
            sayHello();
            formName("Johnny", "Test");
            int result = addNumbers(3, 6);
            Console.WriteLine("Result = " + result);
            double average = findAverage(3, 4, 7);
            Console.WriteLine("Average = " + average);
            string evaluation = isPrime(27);
            Console.WriteLine("The number is " + evaluation);
            int count = countVowels("Hello World");
            Console.WriteLine("Number of vowels in 'Hello World': " + count);
        }
    }
}