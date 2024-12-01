using System;
namespace Program{
    class App{
        public static void Main(string[] args){
            Beverage b = new Beverage("Sweet", "Black", 20);
            b.buyDrink(.25);

            Drinko d = new Drinko("Sweet", "Clear", 30, "Coconut Jelly");
            d.buyDrink(.25);
        }
    }

    class Beverage{
        public string taste;
        public string color;
        public double price;

        public Beverage(string taste, string color, double price){
            this.taste = taste;
            this.color = color;
            this.price = price;
        }

        public virtual void buyDrink(double size){    // using virtual means this is overridden in the derived class
            Console.WriteLine($"I bought a drink that is {this.color} and tastes {this.taste}.");
            Console.WriteLine($"The {size}L bottle costs {this.price}tk.");
        }
    }

    class Drinko: Beverage{
        public string coolFeature;

        public Drinko(string taste, string color, double price, string coolFeature): base(taste, color, price){
            this.coolFeature = coolFeature;
        }

        public override void buyDrink(double size)    // using override to override a function of the base class.
        {
            Console.WriteLine($"I bought Drinko, which has {this.coolFeature}.");
            Console.WriteLine($"The {size}L bottle costs {base.price}tk.");
        }
    }
    
}