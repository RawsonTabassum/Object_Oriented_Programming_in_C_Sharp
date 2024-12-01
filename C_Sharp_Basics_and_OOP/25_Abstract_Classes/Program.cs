using System;
namespace Name
{
    class App{
        public static void Main(string[] args){
            RegularCustomer r = new RegularCustomer("Amy", 1001, 3452);
            MemberCustomer m = new MemberCustomer("Kelly", 1002, 2345);

            r.displayCustomer();
            r.displayDiscount();
            m.displayCustomer();
            m.displayDiscount();
            m.collectPoints();
        }
    }

    abstract class Customer{    // declare the class using the 'abstract' keyword
        public string name;
        public int id;
        public double spent;

        public Customer(string name, int id, double spent){
            this.name = name;
            this.id = id;
            this.spent = spent;
        }

        public abstract void displayDiscount();    // abstract method

        public virtual void displayCustomer(){      // concrete method, that is also virtual, must be overridden in the derived class
            Console.WriteLine($"Name: {name}, ID: {id}, Total Spent: {spent}");
        }
    }

    class RegularCustomer: Customer{
        static double discountRate = 0.05;
        public RegularCustomer(string name, int id, double spent): base(name, id, spent){
            Console.WriteLine("You are a regular customer");
        }

        public override void displayDiscount(){        // overriding the abstract method, the same way as a virtual method
            Console.WriteLine("Your discount rate is: " + discountRate);
        }

        public override void displayCustomer(){         // overriding the virtual method of the base class
            Console.WriteLine($"Name: {name}, ID: {id}, Customer Type: Regular, Total Spent: {spent}tk");
        }
    }

    class MemberCustomer: Customer{
        static double discountRate = 0.08;
        private int points;
        public MemberCustomer(string name, int id, double spent): base(name, id, spent){
            Console.WriteLine("You are a member customer");
        }

        public override void displayDiscount(){         // overriding the abstract method, the same way as a virtual method
            Console.WriteLine("Your discount rate is: " + discountRate);
        }

        public override void displayCustomer(){         // overriding the virtual method of the base class
            Console.WriteLine($"Name: {name}, ID: {id}, Customer Type: Member, Total Spent: {spent}tk");
        }

        public void collectPoints(){
            this.points = this.points + Convert.ToInt32(spent * 0.05);
            Console.WriteLine("Collected points: "+ this.points);
        }
    }
}