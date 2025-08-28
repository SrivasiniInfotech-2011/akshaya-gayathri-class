using Mynamespace.MyMath;
using Testing;
using Math = CSharpAdvanceTraining.Sample.Math;

namespace CSharpAdvanceTraining
{
    class AccessNamespaceClasses
    {
        public static void Main(string[] args)
        {
            Routine.Add(1, 2, 3, 4, 5);
            Mynamespace.HelloWorld.SayHi();
            HelloWorld.TestMessage();
            CSharpAdvanceTraining.Sample.Math math = new CSharpAdvanceTraining.Sample.Math();
            Console.Write("Enter the Number for Performing the Calculation:");
            int angle = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Sine Value of {0} is {1}", angle, math.GetSine(angle));
            Console.WriteLine("CoSine value of {0} is {1}", angle, math.GetCosine(angle));
            Console.WriteLine("Tangent value of {0} is {1}", angle, math.GetTangent(angle));

            CSharpAdvanceTraining.Sample.Text text = new CSharpAdvanceTraining.Sample.Text();
            Console.Write("Enter the Texts to perform Text operations:");
            string text1 = Console.ReadLine() ?? "";
            string text2 = Console.ReadLine() ?? "";
            Console.WriteLine("Reverse of {0} is {1}", text1, text.ReverseString(text1));
            Console.WriteLine("Add text to {0} is {1}", text2, text.AddString(text1, text2));
        }
    }
}
