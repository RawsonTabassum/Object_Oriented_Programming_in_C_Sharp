using System;

namespace ExceptionHandling{
    class App{
        public static void Main(string[] args){
            {
                int a = 10;
                int b = 0;
                try{
                    int result = a / b;
                    Console.WriteLine("The quotient: " + a/b);
                }
                catch(DivideByZeroException e){
                    Console.WriteLine("Here's the caught exception: \n" + e);
                    Console.WriteLine();
                    Console.WriteLine("Here's what happens when you throw an exception:");
                    throw;
                }
                // finally block runs even if an exception is caught or not.
                finally{
                    Console.WriteLine("The program has ended without crashing");
                }
            }

            // These two sections should be different programs, so create two different dotnet consoles and run them
            // otherwise you will only see the output for the first section.
            {
                try{
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age < 0){
                        throw new ArgumentException("Age must be positive");
                    }
                }
                catch (ArgumentException e){
                    Console.WriteLine($"Here's the caught exception:\n{e}");
                }
                finally{
                    Console.WriteLine("Enter a valid age next time");
                }
            }
            
        }
    }

}