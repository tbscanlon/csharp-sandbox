using System;
using System.Collections.Generic; // needed to use dictionaries

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionaries are key-value stores. The key is also a variable
            Dictionary<string, long> phonebook = new Dictionary<string, long>();

            // Adding a new entry to a dictionary
            phonebook.Add("Tom", 08005551234);
            Console.WriteLine(phonebook["Tom"]);

            // Modifying an existing entry in a dictionary
            phonebook["Tom"] = 08005554321;
            Console.WriteLine(phonebook["Tom"]);

            // You can also use this syntax to add a new entry in a dictionary
            phonebook["Alex"] = 08006662345;

            // Searching values in a dictionary
            if (phonebook.ContainsKey("Alex"))
            {
                Console.WriteLine("Alex's number is " + phonebook["Alex"]);
            }

            // Removing an item from a dictionary
            phonebook.Remove("Alex");

            // Removing an item by its key from a dictionary is much quicker than removing from a list by value
        }
    }
}
