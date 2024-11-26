// Inhertitance is one of the four pillars of object-oriented programming
// The mechanism is to inherit or own similar members of another class
// The class that is inherited from is called the base class/ parent class
// The class that inherits is called the derived class/ child class
// We use the : (colon) operator to inherit from one class into another
// By default, classes are assigned the 'internal' access modifier
// Top level classes can only have internal or public access modifiers
// Simialrly, class members can only have public or protected modifiers
// This is because even in case of inheritance, private members of the base class
// remains inaccessible by the derived class
// However, protected members can be accessed by the derived class but not from outside of it


// To initialize base class fields through a derived class constructor, follow these steps
// First declare a base class constructor
// Declare the derived class constructors with parameters for the base class fields
// Example, if base class has fields x, y, z and derived class has fields a, b
// then the derived class constructor will have 5 parameters (a, b, x, y, z)
// Now, pass the parameters of the base class through the base() method after the : operator
// Example: DerivedClass(a, b, c, x, y) : base (x, y, z)

// If you add a print statement in both of the constructors, you will see that 
// both of them are invoked. The base class constructor is invoked first, the derived class constructor
// is invoked next.


using System;
namespace Inheritance{
    class App{
        public static void Main(string[] args){
            DerivedClass d1 = new DerivedClass(1, 2, 3, 4, 5); // passing all 5 parameters 
            d1.a = 4;
            d1.b = 7;
            d1.x = 9;     // public member of base class, so accessible from Main()
            // d1.y = 15  // generates error since y is a protected member of base class
            d1.changeBaseValues();      // this function changes y and z, which is possible since
                                        // y and z are protected and accessible from within the derived class

            Console.WriteLine(d1.a + " " + d1.b + " " + d1.x);

            // using base class method 
            int summation = d1.addNumbers(3, 4);
            Console.WriteLine("The summation: " + summation);
        }
    }

    class BaseClass{
        public int x;
        protected int y, z;

        // Defining base class constructor
        public BaseClass(int x, int y, int z){
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("Invoking Base Class Constructor");
        }

        public int addNumbers(int p, int q){
            return p + q;
        }

    }

    class DerivedClass: BaseClass{
        public int a, b;


        // Only initialize the fields of the same class using its own constructor
        public DerivedClass(int a, int b, int x, int y, int z) : base(x, y, z){
            this.a = a;
            this.b = b;
            Console.WriteLine("Invoking Derived Class Constructor");
        }

        public void changeBaseValues(){
            y = 10;
            z = 10;
            Console.WriteLine(y + " " + z);
        }
    }
}