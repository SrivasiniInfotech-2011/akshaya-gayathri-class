using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanceTraining
{
   public class test
    {
        public void Test()
        {
            Console.WriteLine("I am from test");
        }
    }
    public class Loops
    {
        public static void Main(string[] args)
        {
            //while
            int i = 10;
            while (i >= 0)
            {
                Console.WriteLine("Value of i: {0}", i);
                i--;
            }

            Console.Write("Enter the number till which you want to get the even numbers:");
            int a = int.Parse(Console.ReadLine());
             i = 0;
            while (i <= a)
            {
                if ((i % 2) == 0)
                    Console.WriteLine("{0} is an even number", i);
                i += 1;
            }
            i = 10;
            //Do
            do
            {
                if (i < 0)
                    break;
                Console.WriteLine("Value of i: {0}", i);
                i--;
            } while (i != 10);

            for (int b = 0; b <= 10; b++)
            {
                Console.WriteLine(b);
            }
            ////////for
            for (int j = 0; j <= 10; j++)
            {
                //break and Continue
                if (j % 2 == 0)
                    continue;	//Go to the next item...
                Console.WriteLine("Value of i: {0}", j);
            }

            //Array
            //int[] array = new int[5];
            //for (int idx = 0; idx < array.Length; idx++)
            //{
            //    Console.Write("Enter the value in {0} index: ", idx);
            //    array[idx] = int.Parse(Console.ReadLine());
            //}

            //for (int ix = 0; ix < array.Length; ix++)
            //{
            //    Console.WriteLine("Value in {0} index is {1}", ix, array[ix]);
            //}

            //////foreach
            //foreach (int item in array)
            //{
            //    Console.WriteLine("Value : {0}", item);
            //}

            //int[,] twoDarray = new int[5, 5];

            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < 5; col++)
            //    {
            //        Console.Write("Enter the value in the index: {0},{1}: ", row, col);
            //        twoDarray[row, col] = int.Parse(Console.ReadLine());
            //    }

            //}

            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < 5; col++)
            //    {
            //        //Console.WriteLine("The value in the index: {0},{1} is {2}", row, col, twoDarray[row, col]);
            //        Console.Write("{0}\t", twoDarray[row, col]);
            //    }
            //    Console.WriteLine();
            //}

            //int[,] arr = new int[2, 2];
            //for (int row = 0; row < 2; row++)
            //{
            //    for (int column = 0; column < 2; column++)
            //    {
            //        Console.Write("Enter the value in the index: {0},{1}: ", row, column);
            //        arr[row, column] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int row = 0; row < 2; row++)
            //{
            //    for (int column = 0; column < 2; column++)
            //    {
            //        Console.Write("{0}\t", arr[row, column]);
            //    }
            //    Console.WriteLine();
            //}
            ArrayList objArray = new ArrayList();
            objArray.Clear();
            objArray.Add(1);
            objArray.AddRange(new ArrayList() { "Akshaya", "Vanita" });
            objArray.Add("string");
            objArray.Add('c');
            objArray.Add(new test());
            ArrayList objArrayData = (ArrayList)objArray.Clone();
            objArray.Insert(1, new ArrayList() { "Harshni", "Sample" });
            bool existsone = objArray.Contains("string");
            objArray.Insert(2, 123);
            objArray.Remove(1);
            objArray.RemoveAt(1);
            objArray.RemoveRange(1, 1);
            Array o = objArray.ToArray();

            foreach (object item in objArray)
            {
                if (item.GetType() == typeof(int) || item.GetType() == typeof(string)|| item.GetType() == typeof(char))
                {
                    Console.WriteLine(item);
                }
                else if (item.GetType() == typeof(ArrayList))
                {
                    ArrayList arr1 = (ArrayList)item;
                    foreach (var ar in arr1)
                    {
                        Console.WriteLine(ar);
                    }
                }
                else if (item.GetType() == typeof(test))
                {
                    test o1 = (test)item;
                    o1.Test();
                }
            }
        }
    }
}
