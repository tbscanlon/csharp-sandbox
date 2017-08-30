using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a string variable
            string myString = "A string.";

            // string is an alias for the String object
            String secondString = "A string.";

            // Creating an empty string
            string emptyString = "";
            string betterEmptyString = String.Empty; // this is the preferred method

            // Concatenating strings
            string firstName = "Joe";
            string lastName = "Bloggs";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            // Adding one string to another
            string sentence = "I like to play ";
            sentence += "chess.";
            Console.WriteLine(sentence);

            // Casting objects into strings
            int integer = 1;
            string outString = "Something to be replaced by an int.";
            outString = integer.ToString();
            Console.WriteLine(outString);

            // String formatting
            int x = 1, y = 2;
            int sum = x + y;
            string sumCalculation = String.Format("{0} + {1} = {2}", x, y, sum);
            Console.WriteLine(sumCalculation);

            // SubString
            string fullString = "full string";
            string partOfString = fullString.Substring(5); // takes everything from index 5 onwards
            string shorterPart = fullString.Substring(5, 3); // takes three chars from index 5
            Console.WriteLine(partOfString);
            Console.WriteLine(shorterPart);

            // Search and replace
            string name = "John Doe";
            string newName = name.Replace("John", "Eric");
            Console.WriteLine(newName);

            // Index of - find the first occurence of a string within a larger string.
            // If the string is not found, -1 is returned.
            string fruit = "apple,orange,banana";
            Console.WriteLine("Found orange in position: " + fruit.IndexOf("orange")); // => 6
            Console.WriteLine("Found lemon in position: " + fruit.IndexOf("lemon")); // => -1
        }
    }
}
