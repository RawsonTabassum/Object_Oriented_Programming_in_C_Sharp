// You can declare string variables using ".." and writing any text within it.
// You can attach or concatenate two strings using the + operators.
// You can access individual characters of a string, similar to array indices.
// However, you can change a single character from a string.
// You can find out how many characters consist a string using the string.Length field.
// There are also some string methods. Popular methods are: string.ToUpper() and string.ToLower()
// ToUpper() converts every character within a string into its uppercase form.
// ToLower() converts every character within a string into its lowercase form.


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message1 = "This is an exmaple string";
            string message2 = "Now the strings are attached.";

            Console.Write("String concatenation:");
            Console.WriteLine(message1 + message2);

            Console.WriteLine("The 7th character of message 2 is: " + message2[6]);

            Console.WriteLine("The length of message1 is " + message1.Length);
            Console.WriteLine("Converting message1 to uppercase form: " + message1.ToUpper());
            Console.WriteLine("Converting message1 to lowercase form: " + message1.ToLower());


        }
    }
}
