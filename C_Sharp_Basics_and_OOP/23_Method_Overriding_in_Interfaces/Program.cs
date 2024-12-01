using System;

namespace Program{
    class App{
        public static void Main(string[] args){
            Geometry circle = new Geometry("red", "green", 5);
            Color c = circle;
            Border b = circle;
            c.fillColor("blue");
            b.fillBorder("black", 10);
            c.clear();
            b.clear();
        }
    }

    interface Color{
        public void fillColor(string color);
        public void clear();
    }

    interface Border{
        public void fillBorder(string color, int px);
        public void clear();
    }

    class Geometry: Color, Border{
        public string color;
        public string borderColor;
        public int borderThickness;

        public Geometry(string color, string borderColor, int borderThickness){
            this.color = color;
            this.borderColor = borderColor;
            this.borderThickness = borderThickness;
        }

        void Color.fillColor(string color){
            this.color = color;
            Console.WriteLine($"The color changed to {color}");
        }

        void Color.clear(){
            this.color = "white";
            Console.WriteLine("The color is cleared");
        }

        void Border.fillBorder(string color, int px){
            this.borderColor = color;
            this.borderThickness = px;
            Console.WriteLine($"The border color changed to {color} wiht {px}px thickness");
        }

        void Border.clear(){
            this.borderColor = "white";
            Console.WriteLine("The border is cleared");
        }
    }
}