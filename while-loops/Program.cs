using System;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop
            int n = 0;
            while (n < 50) // variables can't be declared within conditions for a while loop
            {
                n++;

                if (n % 2 != 0)
                {
                    continue; // continue can be used in while loops
                }
                else if (n == 20)
                {
                    break; // break can also be used in while loops
                }

                Console.WriteLine("N is {0}", n);
            }
        }
    }
}
