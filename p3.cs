//NEERAJ-(AI&ML)020
using System;

namespace PrivateConstructorDemo
{
    class MyClass
    {
       
        private string message;

       
        private MyClass()
        {
            message = "Hello from MyClass!";
        }

        
        private static MyClass instance;

        
        public static MyClass GetInstance()
        {
            if (instance == null)
            {
                instance = new MyClass(); 
            }
            return instance;
        }

      
        public void DisplayMessage()
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            MyClass obj = MyClass.GetInstance();

            
            obj.DisplayMessage();

           
            MyClass anotherObj = MyClass.GetInstance();
            Console.WriteLine($"Are both instances the same? {ReferenceEquals(obj, anotherObj)}");

            Console.ReadLine();
        }
    }
}
