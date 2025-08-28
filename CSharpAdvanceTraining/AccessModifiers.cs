using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    /*	Access modifiers
              Modifiers determine how the data members and methods are used in other classes and objects.
              A Class declaration can include a sequence of access.
              Access modifiers can also be applied to methods.
              The different access modifiers can be used in a C-Sharp program are :
              1.Static
              2.Sealed
              3.Abstract
              4.Virtual
              A Static member :
                  - Belongs to a class ,while an instance member belong to an object.
                  - Occupies a single memory location irrespective of the number of instance created for the class.
                  - Does not operate on a specific instance,hence it cannot be accessed using the object name
                  - Is declared using the static keyword.
                  - Is refered to as a class variable, while a non static member is referred to as an instance variable.

      */
    // /// <summary>
    // /// Summary description for Class1.
    // /// </summary>
    // public class static_modifier
    // {
    //     public static void sum(int a, int b)
    //     {
    //         int result = a + b;
    //         Console.WriteLine("The Sum of the numbers is {0}", result);
    //     }
    //
    //     //		[STAThread]
    //     static void Main(string[] args)
    //     {
    //         //				 Static member 'chap10.static_modifier.sum(int, int)' cannot be accessed with an instance reference; qualify it with a type name instead
    //
    //         // static_modifier s = new static_modifier();
    //         // s.sum(10, 20);
    //
    //         			// Static Method used without declaring the instance of the class
    //
    //         static_modifier.sum(10, 20);
    //     }
    // }
// }

    /*The Sealed Modifiers
           - Does not allow a class to be inherited.
           - Is used to create classes in which the the methods canot be overridden.
           - Is used to create standard classes that cannot be derived.
           - Does not allow a method to be overridden.*/


    // sealed class Base1
    /*class Base1
    {
        public void disp()
        {
            Console.WriteLine("Base");
        }
    }
    class Derived : Base1
    {
        public void disp()
        {
            Console.WriteLine("Derived");

        }
        public static void Main()
        {
            Derived d = new Derived();
            d.disp();

        }
    }
}*/

/*The Abstract Modifier
- Is used to define an incomplete class that is referred to as the abstract class.
- An abstract class can act as the base class for other classes.
- An abstract class cannot be instantiated directly.
- An abstract class cannot be sealed.
- An abstract method is one in which the method definition is not given.

*/
//     abstract class Base1
//     // class Base1     //if an abstract method is declared in a non abstract class the compiler generate an error.
//     {
//         public abstract void disp();
//
//         public virtual void add(int a, int b)
//         {
//             Console.WriteLine(a + b);
//         }
//         public int PrinterSetting;
//     }
//
//     class Derived1 : Base1
//     {
//         public override void disp()
//         {
//             base.PrinterSetting = 123;
//             Console.WriteLine("Derived");
//
//         }
//
//         public override void add(int a, int b)
//         {
//             Console.WriteLine(a - b);
//         }
//         public static void Main()
//         {
//
//             // Base1 obj = new Derived1();
//
//             Derived1 d = new Derived1();
//             d.disp();
//             d.add(10,20);
//         }
//     }
// }


/*
 *
    The Virtual Modifier :
        - A virtual modifier is used to declare a virtual method.
        - A virtual method cannot include static,abstract or override modifier.
        - A method that has been declared using the virtual keyword is refered to as a virtual method or a virtual function.

*/
//     class one
//     {
//         public virtual void func()
//         {
//             Console.WriteLine("In func One");
//
//         }
//         public virtual void func1()
//         {
//             Console.WriteLine("In func1 One");
//
//         }
//
//     }
//     class two : one
//     {
//         public override void func()
//         {
//             Console.WriteLine("In func two");
//
//         }
//         public override void func1()
//         {
//             Console.WriteLine("In func1 two");
//
//         }
//
//     }
//     class three : one
//     {
//         public new void func()
//         {
//             Console.WriteLine("In func three");
//
//         }
//         public override void func1()
//         {
//             Console.WriteLine("In func1 three");
//
//         }
//     }
//     class implement
//     {
//         public static void Main()
//         {
//             one o = new two();
//             three t = new three();
//             o.func();
//             o.func1();
//             t.func();
//             t.func1();
//
//             o = t;
//             o.func();
//             o.func1();
//
//             one a = new one();
//             a.func();
//             a.func1();
//
//         }
//     }
// }
/*
    Constructors
        A Constructor is a member that is used to perform actions required to initialise an instance of a class.
        A Constructor has to be declared using the public access specifier.
        The Constructor method should have the same name as the class.
        A class can have multiple constructors.
        A class can have parameterized constructors.

    Destructors
        A destructor is a member that is used to destroy an object of the class.
        A destructor is a method with the same name as the class preceded by the symbol ~.
        A destructor canot take any parameters.
        A class can have only one destructor.


    A constructor is called when an object is created whereas  a destructor is called when an object is destroyed.
 */

//     class myconstructor
//     {
//         string name;
//         public void disp()
//         {
//             Console.WriteLine("Value of the name is {0} ", name);
//         }
//         public myconstructor()
//         {
//             name = "Shalin";
//
//         }
//         public static void Main()
//         {
//             myconstructor cons = new myconstructor();//Creates an instance of the myconstructor class.
//             cons.disp();
//         }
//     }
// }
// Constructor without arguments and Constructor with string parameter
//     class myconstructor
//     {
//         string name;
//         public void disp()
//         {
//             Console.WriteLine("Value of the name is {0} ", name);
//         }
//         public myconstructor()// Constructor without arguments
//         {
//             name = "Shalin";
//
//         }
//         // Constructor with string parameter
//         public myconstructor(string str)
//         {
//             name = str;
//
//         }
//         ~myconstructor()
//         {
//             Console.WriteLine("Object Destroyed");
//             Console.ReadLine();
//         }
//         // Destructor of the class
//         public static void Main()
//         {
//             myconstructor cons = new myconstructor();//Creates an instance of the myconstructor class.
//             cons.disp();
//             myconstructor cons1 = new myconstructor("Srivatsan");
//             cons1.disp();
//             //myconstructor ib = new myconstructor();re
//             Console.ReadLine();
//
//         }
//     }
// }

    class Parent
    {
        string name;

        public Parent()
        {
            this.name = "Sample";
        }

        public Parent(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("{0}", this.name);
        }
    }

    class Child : Parent
    {
        public Child()
        {
        }

        public Child(string name) : base(name)
        {
        }

        static void Main(string[] args)
        {
            Child ch = new Child();
            ch.Display();

            Child ch1 = new Child("Srivatsan");
            ch1.Display();
        }
    }
}