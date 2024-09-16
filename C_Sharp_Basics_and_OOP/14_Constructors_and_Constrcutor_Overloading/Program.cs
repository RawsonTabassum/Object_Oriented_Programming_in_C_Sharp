// Constructors are a special kinds of methods that are invoked automatically when creating an object
// Constructors have the same name as the class and no return type
// We use constructors to initialize the fields of a class with suitable values.
// If we define no explicit constructors, then C# runs a default constructor
// If we define a constructor, we call it a parameterized constructor
// We can define multiple constructors in the same class. This is called constructor overloading.
// Of course, all of the constructors must have some kind of distinction among them.
// We provide this through the parameters it receives.
// We can either change the number of parameters, or we can change the data type of the parameters.
// If we use a constructor to copy the field values of an object into another object, we call it a copy constructor.
// Constructors are usually given the public access modifier. The basic structure is
// public ClassName(parameters list){
//      ...
// }
// Usually, to initialize class fields, we provide the constructors with parameters with the same
// name as the class fields. When assigning values, we use the 'this' operator to distinguish among
// class fields and the parameters. If the class field is x, and we provide the parameter x, 
// we write this.x = x. Here this.x refers to the class field where x refers to the parameter.

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // lets create some person objects
            Person p1 = new Person("Arik", 10);    // uses the constructor with 2 parameters;
            Person p2 = new Person("John", 29, 312351);    // uses the constructor with 3 parameters;

            p1.ageGroup();
            p2.ageGroup();

            // changing the age of p1
            p1.age = 30;
            p1.ageGroup();

            // using copy constructor to create p3 using values of p2
            Person p3 = new Person(p2);
            Console.WriteLine("Displaying fields of p2:");
            p2.displayPerson();

            Console.WriteLine("Displaying fields of p3:");
            p3.displayPerson();

            Console.WriteLine("Displaying fields of p3:");
            p3.name = "Mary";
            p3.displayPerson();
        }
    }

    // Lets start by defining a class
    class Person{
        public string name;
        public int age;
        public int phone;

        // defining a constructor
        public Person(string name, int age, int phone){
            this.name = name;
            this.age = age;
            this.phone = phone;
        }


        // overloading a constructor with a different number of parameters
        public Person(string name, int age){
            this.name = name;
            this.age = age;
        }

        // defining a copy constructor. This also belongs to constructor overloading
        public Person(Person p){
            this.name = p.name;
            this.age = p.age;
            this.phone = p.phone;
        }

        // defining a class method

        public void displayPerson(){
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            if(phone != 0){
                Console.WriteLine("Phone: " + phone);
            }
        }
        public void ageGroup(){
            if (age >= 1 && age <= 12){
                Console.WriteLine(name + " is a child");
            } else if (age >= 13 && age <= 18){
                Console.WriteLine(name + " is a teenager");
            } else if (age >= 19 && age <= 50){
                Console.WriteLine(name + " is an adult");
            } else {
                Console.WriteLine(name + "is an old person");
            }
        }
    }
}