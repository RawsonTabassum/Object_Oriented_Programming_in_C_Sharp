// The for-loop and while-loop in c# are the exact same syntax to c.
// But C# has a new loop, the foreach loop which makes it easy to iterate through arrays and strings.


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printing the natural numbers from 1 to 10
            int n = 1;
            while(n <= 10){
                Console.Write(n + " ");
                n++;
            }
            Console.WriteLine("\n");

            // Printing the triangle pattern
            for(int i=1; i<=4; i++){
                for(int j=1; j<=i; j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Print each character of a string in a new line
            string name = "George";
            foreach(char c in name){
                Console.WriteLine(c);
            }
        }
    }
}