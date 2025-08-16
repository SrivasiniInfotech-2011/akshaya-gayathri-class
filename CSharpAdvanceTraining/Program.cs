using CharpAdvance.Models;
namespace CSharpAdvanceTraining;
internal class Program
{
    static void Main(string[] args)
    {
        //var customer = new Customer("John Doe")
        //{
        //    Id = 1,
        //    Email = "akshaya.test@test.com",
        //    Gender = GenderType.Female,
        //    DateOfBirth = new DateTime(1990, 5, 15)
        //};

        //Console.Write(customer.ToString());

        bool? isValid = true;
        byte age = 25;
        int number = 1000;
        long bigNumber = 10000000000l;
        float pi = 3.14f;
        double eulerNumber = 2.718281828459045d;
        decimal price = 19.99m;
        char initial = 'A';
        string greeting = "Hello, World!";
        DateTime today = DateTime.Now;
        DateTimeOffset offsetDate = DateTimeOffset.Now;
        TimeSpan duration = new TimeSpan(1, 30, 0); // 1 hour and 30 minutes
        Guid uniqueId = Guid.NewGuid();
        object obj = "This is an object type";

        /*
            Continuing with the code, we can explore more about the Type Casting in C#.
         */

        // Implicit Casting
        number = age; // byte to int
        bigNumber = number; // int to long
        //number = greeting;
        // string to int (will cause compile-time error, need to use int.Parse or Convert.ToInt32)
        eulerNumber = pi; // float to double
        //greeting = Convert.ToString(initial);

        //Explicit Casting
        number=(int)bigNumber; // long to int (will cause overflow if bigNumber > int.MaxValue)
        age = (byte)number; // int to byte (will cause overflow if number > 255)
        pi = (float)eulerNumber; // double to float (will cause loss of precision)
        initial = (char)65; // ASCII value to char (65 is 'A')

        var convertable =int.TryParse(greeting, out number); // string to int (will return 0 if parsing fails)
        if(convertable)
        {
            Console.WriteLine($"Parsed number: {number}");
        }
        else
        {
            Console.WriteLine("Parsing failed, invalid input.");
        }
        obj = greeting; // string to object (upcasting)
        obj = number; // int to object (upcasting)
        number =Convert.ToInt32(obj); // object to int (downcasting, will cause runtime error if obj is not an int)
    }
}
