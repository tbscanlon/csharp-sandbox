using System;

namespace for_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Breaking out of a for loop
            for (int n = 0; n < 20; n++)
            {
                Console.WriteLine("Number: " + n);
                if (n == 5)
                {
                    break;
                }
            }

            // Skipping iterations with continue
            for (int y = 0; y < 30; y++)
            {
                if (y % 2 == 1)
                {
                    continue;
                }
                
                Console.WriteLine(y);
            }
        }
    }
}
