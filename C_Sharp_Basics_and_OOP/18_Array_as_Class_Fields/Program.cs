// Sometimes we need arrays as fields of a class. 
// Here's an example:
// A student class contains a field called course. But a student does not only take one course,
// but a set of multiple courses.
// In these instances, using arrays as class fields become necessary.
// To access this field, we can run either a for loop or a foreach loop and read/update the values
// Instaces like this is where you may face the need to pass an array as an argument to a method.
// An easy technique to remember this syntax is the argument of the Main() function. 
// string[] args == datatype[] arr_name (ex: int[] numbers)
// Following code shows an implementation example

using System;

namespace Supershop{
    class App{
        public static void Main(string[] args){
            string[] items_list = {"Bread", "Milk", "Honey", "Fruits", "Oil"};
            Customer c1 = new Customer("Arya", 1001, items_list, 500);

            Console.WriteLine(c1.name);
            Console.WriteLine(c1.custID);
            foreach(string item in items_list){
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(c1.total);
        }
    }

    class Customer{
        public string name;
        public int custID;
        public string[] items = new string[10];
        public double total;

        // defining constructor
        public Customer(string name, int custID, string[] items, double total){
            this.name = name;
            this.custID = custID;
            this.items = items;
            this.total = total;
        }
    }
}