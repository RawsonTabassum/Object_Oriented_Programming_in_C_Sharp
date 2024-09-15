// The syntax for declaring array is
// data-type[] array_name = new data-type[size];
// For an initialized array, data-type[] array_name = {elements}
// In case of uninitialized array, we can either take input from user or generate some numbers
// and assign them to sequential array indices. 

// Implemented array methods in this code are Array.Sort() and Array.IndexOf()
// Array.Length is a property that returns the number of elements in the array.

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialized array
            int[] numbers = {10, 11, 15, 24, 45};

            foreach(int number in numbers){
                Console.WriteLine(number);    // traverses and prints each element of the array
            }

            // uninitialized array
            string[] colors = new string[5];

            for(int i=0; i<5; i++){
                colors[i] = Console.ReadLine();
            }

            // Common array problems are
            // 1. Updating array elements
            // 2. Finding max or min value
            // 3. Sorting an array
            // 4. Searcing through an array and returning the index of an element


            // 1. Updating an array
            // It is possible to access and update individual elements of an array using indexes
            numbers[0] = 14;
            numbers[1] += numbers[1] + 7;
            foreach(int number in numbers){
                Console.Write(number + " ");
            }
            Console.WriteLine();


            // 2. Finding max or min value
            int maxValue = numbers[0];
            int minValue = numbers[0];
            foreach(int number in numbers){
                if(number > maxValue)
                    maxValue = number;
                if(number < minValue)
                    minValue = number;
            }
            Console.WriteLine("The max value from the array is " + maxValue);
            Console.WriteLine("The max value from the array is " + minValue);

            // 3. Sorting an array using the Sort() method
            Array.Sort(numbers);
            Console.Write("The Sorted Array is: ");
            foreach(int number in numbers){
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // 4. Searching an element and finding its index 
            // Finding the index of the color 'red' in the array.
            // If the element exists, we print the index. If it doesnt, print -1
            int indexFound = -1;
            for(int i=0; i<colors.Length; i++){
                if(colors[i] == "red"){
                    indexFound = i;
                    break;
                }
            }
            Console.WriteLine("The index where the color red was found: " + indexFound);

            // the similar index can be found using the IndexOf() method 
            indexFound = Array.IndexOf(colors, "blue");
            Console.WriteLine("The index where the color blue was found: " + indexFound);
        }
    }
} 