// classes are a kind of user-defined data type.
// informally, we call classes the blueprints for creating objects
// objects are variables of a class data type. Objects are also called instances of a class
// a class can have fields i.e. member variables, properties and methods
// the basic structure of a class
// class ClassName {
//      define fields
//      define properties
//      define methods
// }
// the syntax for creating an object
// ClassName objectName = new ClassName()
// Try naming the classes in PascalCase - Meaning Each Word start with a Capital Letter.
// Classes are defined outside of the Program class, so make sure you do not mess it up.

// By default, all of the class fields, properties and methods are private.
// This means that we can not access any of it outside of the class.
// To gain access to necessary class fields, properties and methods, we need to change the access modifier.
// Access modifiers are: public, private, protected and internal.
// By changing the modifier from private to public we can gain access to the class members.
// We can even change the values of the class fields directly, if it has the public modifier.
// For now, we only deal with private and public modifiers. We'll learn more about protected modifier
// later when we learn inheritance. 

using System;
using System.Runtime.CompilerServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating objects
            Animal cat = new Animal();
            
            // we access class fields, properties and methods using the (.) operator
            // let us set some values to the class properties
            cat.name = "cat";
            cat.color = "black";
            cat.weight = 5;
            // cat.lifeSpan = 20;    // running this statement will generate an error, since lifeSpan is a private field.
            cat.displayAnimal(); 

            // let us change the properties and display again
            cat.color = "orange";
            cat.weight = 7;
            cat.displayAnimal();


            // try creating a dog now.
        }
    }

    // Lets define some class
    class Animal{

        // class Fields
        public string name;
        public string color;
        public double weight;
        private int lifeSpan;

        // For now, we skip class properties

        // class method, we've already covered this. However, if we skip the 'static' keyword
        // from our previous discussion on methods, then the methods change from being static methods to
        // instance methods.
        // this means that to use these methods, we will need to create instances or objects of the class
        public void displayAnimal(){
            Console.WriteLine("The animal is a " + color + " " + name + " and it weighs " + weight + " kilograms");
        }
    }
}
