using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] newNums = new int[10];

            // Prints data type
            Console.WriteLine(nums);
            Console.WriteLine(newNums);

            // Prints length
            Console.WriteLine(nums.Length);
            Console.WriteLine(newNums.Length);

            // Prints value at index
            // Note: C# is zero-indexed
            Console.WriteLine(nums[2]); // third element
            Console.WriteLine(newNums[6]); // seventh element

            // Print every element in an array
            foreach (var item in nums)
            {
                Console.WriteLine(item.ToString());
            }

            // Multidimensional arrays
            int[,] matrix = new int[2,2];

            matrix[0,0] = 1;
            matrix[0,1] = 2;
            matrix[1,0] = 3;
            matrix[1,1] = 4;

            // Print every element in a multidimensional array
            foreach (var dimension in matrix)
            {
                Console.WriteLine(dimension.ToString());
            }
        }
    }
}
