//NEERAJ-(AI&ML)020
//Create a program to show the usage of static constructor


using System;
namespace StaticConstructorDemo
{
    class MyClass
    {
        
        private static int staticValue;

        
        private int instanceValue;

        
        static MyClass()
        {
            Console.WriteLine("Static constructor called!");
            staticValue = 100;
        }

        
        public MyClass(int value)
        {
            Console.WriteLine("Instance constructor called!");
            instanceValue = value;
        }

        
        public void DisplayValues()
        {
            Console.WriteLine($"Static Value: {staticValue}, Instance Value: {instanceValue}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating first object:");
            MyClass obj1 = new MyClass(10);
            obj1.DisplayValues();
            Console.WriteLine();

            Console.WriteLine("Creating second object:");
            MyClass obj2 = new MyClass(20);
            obj2.DisplayValues();

            Console.ReadLine();
        }
    }
}
