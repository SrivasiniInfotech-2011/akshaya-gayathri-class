using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    enum Colors :int
    {
        Red = 1213,
        Blue = 1314,
        Green = 1516
    }
    enum Choice
    {
        Add = 1,
        Sub = 2,
        Mul = 3,
        Div = 4
    }
    //class Enums
    //{
    //    public static void Main(string[] args)
    //    {
    //        //int inputColor = int.Parse(Console.ReadLine());
    //        //if (inputColor == (int)Colors.Red)
    //        //    Console.WriteLine("The selected color is: {0}", Colors.Red.ToString());
    //        //else if (inputColor == (int)Colors.Green)
    //        //    Console.WriteLine("The selected color is: {0}", Colors.Green.ToString());
    //        //else if (inputColor == (int)Colors.Blue)
    //        //    Console.WriteLine("The selected color is: {0}", Colors.Blue.ToString());
    //        //else
    //        //    Console.WriteLine("Please select a valid color");

    //        string inputColor = Console.ReadLine();
    //       Enum.TryParse(enumType: typeof(Colors), value: inputColor, ignoreCase: true, out object color);

    //        switch ((Colors)color)
    //        {
    //            case Colors.Red:
    //                Console.WriteLine("The selected color is: {0}", Colors.Red.ToString());
    //                break;
    //            case Colors.Blue:
    //                Console.WriteLine("The selected color is: {0}", Colors.Blue.ToString());
    //                break;
    //            case Colors.Green:
    //                Console.WriteLine("The selected color is: {0}", Colors.Green.ToString());
    //                break;
    //            default:
    //                Console.WriteLine("Please select a valid color");
    //                break;
    //        }
    //    }
    //}

    class Calculator
    {
        int a;
        int b;

        public Calculator()
        {
            this.a = 0;
            this.b = 20;
        }

        public Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        ~Calculator()
        {
            Console.WriteLine("Program Execution Competed!");
        }
        public void Calculate(Choice choice)
        {
            switch (choice)
            {
                case Choice.Add:
                    Console.WriteLine("The Sum of {0} and {1} is : {2}", a, b, a + b);
                    break;
                case Choice.Sub:
                    Console.WriteLine("The Subraction of {0} and {1} is : {2}", a, b, a - b);
                    break;
                case Choice.Mul:
                    Console.WriteLine("The Multiplication of {0} and {1} is : {2}", a, b, a * b);
                    break;
                case Choice.Div:
                    Console.WriteLine("The Division of {0} and {1} is : {2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Please select a valid choice");
                    break;
            }
        }
    }

    class ExecuteCalculator
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the First Number:");
            int.TryParse(Console.ReadLine(), out int a);

            Console.Write("Enter the Second Number:");
            int.TryParse(Console.ReadLine(), out int b);

            Console.Write("Enter the Choice:");
            Enum.TryParse(Console.ReadLine(), true, out Choice c);
            Calculator calculator = new Calculator(a, b);
            calculator.Calculate(c);
        }
    }
}
