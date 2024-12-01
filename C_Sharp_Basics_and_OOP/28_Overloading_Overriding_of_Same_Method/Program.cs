using System;
namespace Name
{
    class App{
        public static void Main(string[] args){
            Husky h = new Husky("Larry", 2, "Husky", 10);
            h.display("Gene");
            h.adopt();
            h.display("Gene");
        }
    }

    class Dog{
        public string name;
        public int age;

        public Dog(string name, int age){
            this.name = name;
            this.age = age;
        }

        public virtual void display(){
            Console.WriteLine("Dog information:");
            Console.WriteLine($"Name: {this.name}, age: {this.age}");
        }
    }
    
    class Husky: Dog{
        public string breed;
        public double weight;
        bool isAdopted = false;

        public Husky(string name, int age, string breed, double weight): base(name, age){
            this.breed = breed;
            this.weight = weight;
        }

        public override void display(){
            Console.WriteLine("Dog information:");
            Console.WriteLine($"Name: {base.name}, Age: {base.age} years, Breed: {this.breed}, Weight: {this.weight} kg");
        }

        public void adopt(){
            isAdopted = true;
            Console.WriteLine($"You just adopted the {base.name}!");
        }

        public void display(string owner){
            Console.WriteLine("Dog information:");
            Console.WriteLine($"Name: {base.name}, Age: {base.age} years, Breed: {this.breed}, Weight: {this.weight}");
            if(isAdopted){
                Console.WriteLine($"{base.name}'s owner is {owner}");
            } else {
                Console.WriteLine($"{owner} has not adopted {base.name} yet");
            }
        }

    }
}