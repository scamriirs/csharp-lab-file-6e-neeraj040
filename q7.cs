//NEERAJ-(AI&ML)020
//Write a program  to show usage of this keyword 

using System;

namespace ThisKeywordDemo
{
    class Student
    {
        private string name;
        private int age;

       
        public Student(string name, int age)
        {
            this.name = name; 
            this.age = age;
        }

        
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }

        
        public Student() : this("Default Name", 18)
        {
            Console.WriteLine("Default constructor called!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student("Alice", 20);
            student1.DisplayDetails();

            Console.WriteLine();

          
            Student student2 = new Student();
            student2.DisplayDetails();

            Console.ReadLine();
        }
    }
}
