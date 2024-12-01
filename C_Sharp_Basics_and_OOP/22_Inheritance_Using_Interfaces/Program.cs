// Interfaces are essentially a contract that enforces a set of methods that a class must implemet
// They do not contain any code, only the declaration of methods
// C# allows multiple inheritance because unlike classes, this does not cause ambiguity issues
// Classes that inherit an interface must override the methods, otherwise produces error
// Interface inheritance works similar to classes
// While overriding methods, it is better to mention from which interface the method is coming from
// We do this by using the .(dot) operator. 
// For example, for interface Payment, override the method paypal with syntax Payment.paypal() 

// While using overridden methods, first create the object of the class, then create object of the interface
// Finally, assign the class object to the interface object.

using System;

namespace Interface{
    class App{
        public static void Main(string[] args){
            Card c = new Card();
            Paypal p = c;
            p.payment();
            Transaction t = c;
            t.completeTransaction(1200);
        }
    }

    interface Paypal{
        public void payment();    // add a semicolon after function declaration.
    }

    interface Transaction{
        public void completeTransaction(double balance);
    }

    class Card : Paypal, Transaction{       // multiple inheritance
        protected double balance;
        public Card(){
            this.balance = 10000;
        }

        void Paypal.payment(){
            Console.WriteLine("Making payment using paypal");
        }

        void Transaction.completeTransaction(double balance){
            this.balance += balance;
            Console.WriteLine("The transaction is complete");
            Console.WriteLine($"New balance: {this.balance}");
        }
    }
}