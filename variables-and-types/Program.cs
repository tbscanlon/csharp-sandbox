using System;

namespace variables_and_types
{
    class Program
    {

    public enum CarType
    {
        // Enums should be used to specify an option from a pre-set fixed amount
        Toyota = 1,
        Honda = 2,
        Ford = 3,
    }
        static void Main(string[] args)
        {
            // C# is statically typed. Variable types must be declared before use
            int myInt = 1;          // integer
            float myFloat = 1f;     // Floating point (notice the 'f' after the number)
            bool myBoolean = true;  // boolean
            string myName = "Tom";  // text string
            char myChar = 'a';      // text character
            double myDouble = 1.75; // double-precision floating point

            // C# supports type inference. The compiler can try to determine a variable type.
            // Once a type has been set, it cannot be changed.
            var x = 1; // integer
            var y = 2; // integer
            var sum = x + y; // Also an integer

            CarType myCarType = CarType.Toyota; // using an enum as a variable
        }
    }
}
