using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example method
            Console.WriteLine(Multiply(5, 10));
            Console.WriteLine(Foo());
            ReturnNothing();
            Console.WriteLine(Concatenate("hello", "friends"));
        }

        // Method syntax:
        // Modifiers; Type of Output; Name; (params)
        public static int Multiply(int x, int y) // Static methods are equivalent to class methods in Ruby
        {
            return x * y;
        }

        public static int Foo()
        {
            return 0;
        }

        public static void ReturnNothing()
        {
            Console.WriteLine("I'm within a method hello from the method");
            return;
        }

        private static string Concatenate(string a, string b) // assuming that private methods can't be called from outside object, like in Ruby
        {
            return a + " " + b;
        } 
    }
}
