// See more about destructors in the shallow vs deep copy code.
// Here is just a basic implementation.
// You can also evaluate the calling sequence of the constructors in inheritance
// Unfortunately, you can not see the sequence in case of a destructor
// Copy and paste the code in an onlihne compiler to see the destructor in action.


using System;

namespace Destructor{
    class App{
        public static void Main(string[] args){
            A a = new A(1, 2, 3);    // invokes only the constructor of A
            B b = new B(4, 5, 6, 7, 8);     // invokes the constructors of both A and B
        }
    }

    class A{
        public int a, b, c;
        public A(int a, int b, int c){
            this.a = a;
            this.b = b;
            this.c = c;
            Console.WriteLine("The constructor of A is invoked");
        }

        ~A(){
            Console.WriteLine("The destructor of A is called");
        }
    }

    class B: A{
        public int x, y;
        public B(int a, int b, int c, int x, int y): base(a, b, c){
            this.x = x;
            this.y = y;
            Console.WriteLine("The constructor of B is invoked");
        }

        ~B(){
            Console.WriteLine("The destructor of B is called");
        }
    }
}