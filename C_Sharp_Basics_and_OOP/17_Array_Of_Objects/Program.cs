// We know about arrays and objects
// It is possible to delcare arrays of objects
// These are espacially useful when dealing with multiple objects of the same class
// For example, objects of the class Student. Certainly, an institute has more than 
// one students and rather than declaring each student as separate objects,
// we can declare an array to store the objects.
// Syntax for declaring an array
// datatype[] arr_name = new datatype[size]
// since classes are a custom data type, so we can declare arrays using the following syntax
// className[] arr_name = new className[size]
// Then we can access all the public fields and methods of the class through array indexing
// arr_name[i].field, arr_name[i].method() etc. Here, i is an arbitraty index
// check out the following code


using System;

namespace Project{
    class App{
        public static void Main(string[] args){
            string[] book_names = {"Animal Farm", 
                                    "The Little Prince", 
                                    "The Alchemist",  
                                    "Neuromancer", 
                                    "The Hobbit"
                                    };
            string[] writers = {"George Orwell",
                                "Antoine de Saint-Exupery", 
                                "Paolo Coelho", 
                                "William Gibson", 
                                "J.R.R. Tolkien"
                                };
            string[] genres = {"Satire", "Children fiction", "Fantasy", "Cyberpunk", "Fantasy"};
            double[] prices = {290, 240, 200, 250, 270};

            // declaring array of objects
            Book[] books = new Book[5];
            
            for(int i=0; i<10; i++){
                books[i] = new Book(book_names[i], genres[i], writers[i], prices[i]);
                books[i].displayBook();
            }
        }
    }

    class Book{
        public string name;
        public string genre;
        public string writer;
        private double price;

        // constructor
        public Book(string name, string genre, string writer, double price){
            this.name = name;
            this.genre = genre;
            this.writer = writer;
            this.price = price;
        }

        public void displayBook(){
            Console.WriteLine($"Book name: {this.name}, Writer: {this.writer}, Genre: {this.genre}, price: {this.price}");
        }

    }
}