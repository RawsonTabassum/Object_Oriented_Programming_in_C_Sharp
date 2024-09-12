// The switch statement can also be applied to check conditions in a code
// This statement compares the target variable with each case and executes the respective code block.
// It is important to use the 'break' keyword after each case, otherwise the code proceeds to
// the next case.
// Sometimes we provide a default case, so that when none of the cases matches, the code can still show some
// output to the user.
// It multiple cases have the same code to execute, we can write down the cases without any code block
// and only add the code block at the last case.

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            switch(number){
                case >0:
                    Console.WriteLine("Positive Number");
                    break;
                case <0:
                    Console.WriteLine("Negative Number");
                    break;
                case 0:
                    Console.WriteLine("Zero");
                    break;
            };


            char alphabet = 'p';

            switch(alphabet){
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
        }
    }
}