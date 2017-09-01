using System;

namespace classes
{
    // Everything is an object in C#, like Ruby
    class MainClass
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            Console.WriteLine(tom.test);

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Console.WriteLine(car1.year);
            Console.WriteLine(car2.year);
            Console.WriteLine(car3.year);
        }
    }

    class Person
    {
        public string test = "hello friends";
    }

    class Car
    {
        public int numTires = 4;
        public int year = 2000;
        public bool runs = true;
    }
}
