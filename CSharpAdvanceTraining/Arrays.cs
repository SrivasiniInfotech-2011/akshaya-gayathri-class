using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanceTraining
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            // Declare and initialize an array of integers
            int[] arr =new int[5]{1,2,3,4,5};
          
            //Two Dimensional Array
            int[,] twoDimensionalArray= new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            foreach (int number in arr)
            {
                Console.WriteLine(number);
            }

            // Accessing elements in a two-dimensional array
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    Console.Write(twoDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Jagged Array (Array of Arrays)

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine("Jagged Array Elements:");
            
        }
    }
}
