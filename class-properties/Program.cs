using System;

namespace class_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Shape("square", 4, 1, 1);
            Shape triangle = new Shape("triangle", 3, 3, 3.9);

            Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", square.Type, square.Sides, square.SideLength, square.Area);
            Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", triangle.Type, triangle.Sides, triangle.SideLength, triangle.Area);

            Vehicle car = new Vehicle("car", 4, 2000, true);
            Vehicle oldCar = new Vehicle("car", 4, 1980, false);
            Vehicle bike = new Vehicle("bike", 2, 2017, true);

            Console.WriteLine("Vehicle Type: {0} | Wheels: {1} | Year: {2} | Works?: {3}", car.Type, car.NumTires, car.Year, car.Runs);
            Console.WriteLine("Vehicle Type: {0} | Wheels: {1} | Year: {2} | Works?: {3}", oldCar.Type, oldCar.NumTires, oldCar.Year, oldCar.Runs);
            Console.WriteLine("Vehicle Type: {0} | Wheels: {1} | Year: {2} | Works?: {3}", bike.Type, bike.NumTires, bike.Year, bike.Runs);
        }
    }

    class Shape
    {
        // Declaring variables without values in a class
        public string Type;
        public int Sides;
        public int SideLength;
        public double Area;

        public Shape(string type, int sides, int sideLength, double area) // Constructor
        {
            Type = type;
            Sides = sides;
            SideLength = sideLength;
            Area = area;
        }
    }

    class Vehicle
    {
        public string Type;
        public int NumTires;
        public int Year;
        public bool Runs;

        public Vehicle(string type, int numTires, int year, bool runs)
        {
            Type = type;
            NumTires = numTires;
            Year = year;
            Runs = runs;
        }
    }
}
