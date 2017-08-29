using System;
using System.Collections.Generic; // need to load this in to use lists

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists are dynamically sized, unlike arrays which are fixed to a declared size.

            // Creating a new list
            List<int> numbers = new List<int>();

            // Adding numbers to a list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            // Adding a range of numbers to a list using an array
            int[] array = new int[] { 4, 5, 6 };
            numbers.AddRange(array);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);   
            }

            // Removing elements from a list
            List<string> fruits = new List<string>();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("orange");

            fruits.Remove("banana");
            Console.WriteLine(fruits.Count);

            // Removing by index
            fruits.RemoveAt(1);
            Console.WriteLine(fruits.Count);

            // Concatenating lists
            List<string> vegetables = new List<string>();
            vegetables.Add("tomato");
            vegetables.Add("carrot");

            fruits.AddRange(vegetables);
            Console.WriteLine(fruits.Count);
        }
    }
}
