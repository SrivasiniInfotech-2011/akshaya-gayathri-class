using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpBasics;
namespace CSharpTraining
{
    //public delegate bool ComparerDelegate(int a, int b);
    //public class SampleDelegateImplementation
    //{
    //    public static void Main(string[] args)
    //    {
    //        ComparerDelegate delObj = new ComparerDelegate(CompareInt);
    //        int a = 10, b = 20;
    //        string equality = delObj(a, b) ? "are Equal" : "are not Equal";
    //        Console.Write("The numbers {0} and {1} {2}", a, b, equality);
    //    }

    //    public static bool CompareInt(int a, int b) => a == b;
    //}
    //public class Delegates
    //{
    //    delegate int NumberChanger(int n);
    //    delegate bool IntegerComparer(int a, int b);

    //    public static bool CompareInt(int x, int y)
    //    {
    //        return x > y;
    //    }

    //    static int num = 10;
    //    public static int AddNum(int p)
    //    {
    //        num += p;
    //        return num;
    //    }

    //    public static int MultNum(int q)
    //    {
    //        num *= q;
    //        return num;
    //    }

    //    public static int getNum()
    //    {
    //        return num;
    //    }

    //    public static void Main(string[] args)
    //    {

    //        Console.Write("Enter the First Value:");
    //        int a = int.Parse(Console.ReadLine());

    //        Console.Write("Enter the Second Value:");
    //        int b = int.Parse(Console.ReadLine());

    //        //Comparer comp = new Comparer(CompareInt);
    //        IntegerComparer comp = new IntegerComparer(CompareInt);
    //        Console.WriteLine(comp(a, b));

    //        //Console.Write("Enter the Value:");
    //        //int a = int.Parse(Console.ReadLine());

    //        NumberChanger nc;
    //        NumberChanger nc1 = new NumberChanger(AddNum);
    //        NumberChanger nc2 = new NumberChanger(MultNum);

    //        nc = nc1 + nc2;

    //        Console.WriteLine(nc(a));
    //    }
    //}

    public class Delegate_Test
    {
        public static int ReturnDelegateResult(NumericDelegate numericDelegate, int a, int b)
        {
            if (numericDelegate != null)
                return numericDelegate(a, b);
            return 0;
        }
    }
    public class Delegates
    {
        public static void Main(string[] args)
        {
            NumericDelegate numericDelegateAdd = new NumericDelegate(DelegateImplementor.Add);
            NumericDelegate numericDelegateSubract = new NumericDelegate(DelegateImplementor.Subract);
            Console.Write("Enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition: {0}", numericDelegateAdd(a, b));
            Console.WriteLine("Subraction: {0}", numericDelegateSubract(a, b));
            Console.WriteLine("Delegate_Test Result 1 :{0}", Delegate_Test.ReturnDelegateResult(numericDelegateAdd, a, b));
            Console.WriteLine("Delegate_Test Result 2 :{0}", Delegate_Test.ReturnDelegateResult(numericDelegateSubract, a, b));
            Console.WriteLine("Delegate_Test Result 3 :{0}", Delegate_Test.ReturnDelegateResult(null, a, b));

            NumericDelegate nc = numericDelegateAdd + numericDelegateSubract;
            Console.WriteLine("Multi Cast: {0}", nc(a, b));
            Console.ReadLine();
        }

    }
    public class DelegateImplementor
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subract(int a, int b)
        {
            return a - b;
        }
        public static string StringConcatenation(string a, string b)
        {
            return a + b;
        }
    }
}
