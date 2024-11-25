// We've already had some idea about method overloading through
// constructor overloading, where we define multiple constructors with different parameters list
// In case of method overloading, we define more than one methods with the same name but
// assign different signatures to them.
// We can assign different signatures through different numbers of parameters
// Example: int func(int x) and int func(int x, int y) have separate signatures
// Finally, we can have same name and same number of parameters but we can change the type of the parameters
// Example: int func(int x, int y) and int func(string x, string y) are considered different functions


using System;
using System.Runtime.Intrinsics.X86;
namespace MethodOverloading{
    class App{
        public static void Main(string[] args){
            Bank b1 = new Bank(1000);
            double balanceWithoutInterest = b1.calculateCapital(500);
            double balanceWithInterest = b1.calculateCapital(500, 5);
            double stringBalanceWithInterest = b1.calculateCapital("500", 5);
            Console.WriteLine(b1.balance);

            // checking type
            Console.WriteLine(b1.balance.GetType());

        }
    }

    class Bank{
        public double balance;
        public Bank(int balance){
            this.balance = balance;
        }

        public double calculateCapital(double capital){
            balance += capital;
            return balance;
        }

        // overloading by changing parameters list
        public double calculateCapital(double capital, double interestRate){
            balance = balance + capital + (capital * interestRate)/100;
            return balance;
        }

        // overloading by changing parameters data types
        public double calculateCapital(string capital, double interestRate){
            double newCapital = Convert.ToDouble(capital);
            balance = balance + newCapital + (newCapital * interestRate)/100;
            return balance;
        }
    }
}