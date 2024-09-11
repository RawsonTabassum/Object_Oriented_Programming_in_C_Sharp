// To evaluate a condition in C#, we use the if-else statement, exact to that of C.
// if a condition is true, the code block under the if-statement is executed.
// if the condition is false and an else-statement exists, then the else-block is executed.
// to facilitate multiple comparison, we use the if - else if -else structure.
// it is possible to nest if-else if-else statements for complex conditions.

// We'll be using a fun example to explain all of these cases.


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRaining = true;
            Console.WriteLine("Going to school is important.");

            //if block only
            if(isRaining == true){
                Console.WriteLine("It is raining so I won't go to school");
            }

            isRaining = false;

            //if-else block
            if(isRaining == true){
                Console.WriteLine("It is raining so I won't go to school");
            } else {
                Console.WriteLine("It is not raining so I will go to school.");
            }

            int time = 10;


            // if-else if-else block
            if (time < 10){
                Console.WriteLine("I am early to my class.");
            } else if (time == 10){
                Console.WriteLine("I am just in time for my class.");
            } else {
                Console.WriteLine("I am late for my class.");
            }

            isRaining = false;
            bool haveUmbrella = false;
            bool haveSunGlass = true;

            
            // Nested if-else statement
            if(isRaining == true){
                if(haveUmbrella == true){
                    Console.WriteLine("It is raining but I have an umbrella.");
                }
                else {
                    Console.WriteLine("It is raining and I don't have an umbrella.");
                }
            } else {
                if(haveSunGlass == true){
                    Console.WriteLine("It is not raining and I am wearing a sunglass.");
                }
                else {
                    Console.WriteLine("It is not raining but I forgot my sunglass.");
                }
            }
            

        }
    }
}