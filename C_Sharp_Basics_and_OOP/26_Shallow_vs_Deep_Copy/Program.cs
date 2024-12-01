using System;
namespace Copies{
    class App{
        public static void Main(){
            ShallowCopy sc1 = new ShallowCopy(1, 2.3, "4");
            ShallowCopy sc2 = sc1;

            sc1.x = 10;
            sc2.y = 20.3;
            Console.WriteLine($"Value of x: {sc1.x} and {sc2.x}");
            Console.WriteLine($"Value of y: {sc1.y} and {sc2.y}");

            DeepCopy dc1 = new DeepCopy(5, 6.7, "8");
            DeepCopy dc2 = new DeepCopy(dc1);
            
            dc1.x = 50;
            dc2.y = 60.7;
            Console.WriteLine($"Value of x: {dc1.x} and {dc2.x}");
            Console.WriteLine($"Value of y: {dc1.y} and {dc2.y}");

            int a = 0;
            for(int i=0; i<=1000; i++){
                a++;
            }
        }
    }

    class ShallowCopy{
        public int x;
        public double y;
        public string z;

        public ShallowCopy(int x, double y, string z){
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("New Shallowcopy object created");
        }

        ~ShallowCopy(){
            Console.WriteLine("Shallowcopy object is destroyed");
        }
    }

    class DeepCopy{
        public int x;
        public double y;
        public string z;

        public DeepCopy(int x, double y, string z){
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("New Deepcopy object created");
        }

        public DeepCopy(DeepCopy d){
            this.x = d.x;
            this.y = d.y;
            this.z = d.z;
            Console.WriteLine("New Deepcopy object created");
        }

        ~DeepCopy(){
            Console.WriteLine("Deepcopy object is destroyed");
        }
    }
}