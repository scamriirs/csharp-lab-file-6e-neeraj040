//create a program in c# to show the usage of 
//-Parameterized constructor
//-Parameter less constructor
//-Default constructor

using System;

namespace ConstructorDemo
{
    class Person
    {
        private string name;
        private int age;
        public Person()
        {
            Console.WriteLine("Default Constructor called!");
            name = "Unknown";
            age = 0;
        }
        public Person(string defaultName)
        {
            Console.WriteLine("Parameterless Constructor called!");
            name = defaultName;
            age = 18; // Default age
        }
        public Person(string name, int age)
        {
            Console.WriteLine("Parameterized Constructor called!");
            this.name = name;
            this.age = age;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using the default constructor
            Console.WriteLine("Creating object with Default Constructor:");
            Person person1 = new Person();
            person1.DisplayDetails();
            Console.WriteLine();

            // Using the parameterless constructor
            Console.WriteLine("Creating object with Parameterless Constructor:");
            Person person2 = new Person("John Doe");
            person2.DisplayDetails();
            Console.WriteLine();

            // Using the parameterized constructor
            Console.WriteLine("Creating object with Parameterized Constructor:");
            Person person3 = new Person("Alice", 25);
            person3.DisplayDetails();

            Console.ReadLine();
        }
    }
}
