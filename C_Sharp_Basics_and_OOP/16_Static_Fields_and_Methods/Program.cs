// The static keyword is used in C# to create class variables and class methods.
// Class variables and class methods can be accessed without creating objects, unlike instance variables and methods
// Also class variables and class methods are shared as a common memory space for all objects.
// Updating a class variable will change the value for that variable for all the objects, unlike instance
// variables where an object can only update its own fields and can not affect the fields of other objects.
// static can be applied to class but we can not create instances/ objects of a static class.
// The members of a static class (fields, properties and methods) must also be staic.

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DemoClass obj = new DemoClass();     // running this code will generate error since DemoClass is
                                                    // a static class and it does not allow creating objects.

            // using class method without creating objects
            Student.displayInstitute();

            // creating objects
            Student s1 = new Student("Maria", "202401", "BBA");
            Student s2 = new Student("Jimmy", "202403", "CSE");
            Student s3 = new Student("Ali", "202404", "EEE");
            
            // Displaying private values through properties
            Console.WriteLine(s1.StudentName + " " + s1.StudentID + " " + s1.Department);

            // s1.StudentName = "Riya";     // running this statement will generate an error because in this case
                                            // we did not define the set methods for any of the properties.
                                            // meaning that we have restricted the updation access.
                                            // so we can not set values of StudentName, StudentID and Department (properties) 
                                            // but we can always get the values as the get methods are defined.
            
            // Displaying private values through properties
            Console.WriteLine(s1.StudentName + " " + s1.StudentID + " " + s1.Department);
            // This statement does not generate error since the get method is defined.

            // Console.WriteLine(s1.StudentCount);      // running this code may generate an error saying that
                                                        // a class variable can not be accessed with an instance reference
            
            // accessing the class variables
            Console.WriteLine("Total Students of " + Student.University + ": " + Student.StudentCount);
            Console.WriteLine("Displaying Student Information:");
            s1.displayStudentInfo();
            s2.displayStudentInfo();
            s3.displayStudentInfo();
            
            Student.displayInstitute();
        }
    }

    // Defining classes
    static class DemoClass{
        static int x = 0;
        static int y = 0;
    }

    class Student{
        private string studetName;
        private string studentID;
        private string department;

        public static int StudentCount = 0;
        public static string University = "Uttara University";


        // defining constructor
        public Student(string studetName, string studentID, string department){
            this.studetName = studetName;
            this.studentID = studentID;
            this.department = department;
            StudentCount++;
        }

        // defining property for get method only
        public string StudentName{
            get{
                return studetName;
            }
        }

        public string StudentID{
            get{
                return studentID;
            }
        }

        public string Department{
            get{
                return department;
            }
        }

        // Defining a static method
        public static void displayInstitute(){
            Console.WriteLine(University + " has " + StudentCount + " students");
        }

        public void displayStudentInfo(){
            Console.WriteLine(StudentName + " with ID " + studentID + " is from " + department + " department");
        }
    }
}