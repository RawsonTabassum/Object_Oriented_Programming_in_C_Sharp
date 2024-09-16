// We've already learned about access modifiers of a class: private, public, protected and internal
// We also know that by default, the class members have the private modifier assigned to them
// To get access to private class fields and update them, we use the property member of the class
// Properties look similar to variables but contain the get and set methods within it.
// The basic structure of a property is 
// public data_type PropertyName{
//      get{}
//      set{}
// }

// So, properties have a data type assigned and this data type is the same as the field it has access over.
// Usually  property names also follow the PascalCase format.
// The get method returns the value of the desired class field.
// The set method sets or updates the desired class field.
// It is possible to use the same property to assign values to multiple class field of the same data type.
// It is also possible to write more instruction within the get and set methods besides returning or setting values.
// But we skip that part for now.

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating book objects
            Book b1 = new Book("Pride and Prejudice", 500, "Jane Austine");
            Book b2 = new Book("Holly", 320, "Stephen King");

            // b1.bookName = "Something else";      // running this statement will generate an error, since
                                                    // bookName is a private variable. Same for price and writer.
                                                    // We instead use properties BookName, Price and Writer.
            b1.bookInfo();
            b2.bookInfo();

            b1.BookName = "Hamlet";
            b1.Writer = "William Shakespeare";
            b1.bookInfo();

            // Similarly we can update the information of Book b2. Try it.
        }
    }

    // Defining a class
    class Book {
        private string bookName;
        private decimal price;
        private string writer;


        // Defining constructor
        public Book(string bookName, decimal price, string writer){
            this.bookName = bookName;
            this.price = price;
            this.writer = writer;
        }

        // Defining property for bookName
        public string BookName{
            get {
                return bookName;
            }
            set {
                bookName = value;
            }
        }

        // Defining property for price
        public decimal Price{
            get {
                return price;
            }
            set {
                price = value;
            }
        }

        // Defininf property for writer
        public string Writer{
            get {
                return writer;
            }
            set {
                writer = value;
            }
        }

        // defining method
        public void bookInfo(){
            Console.WriteLine(bookName + " by " + writer);
            Console.WriteLine("Price: " + price);
        }
    }
}