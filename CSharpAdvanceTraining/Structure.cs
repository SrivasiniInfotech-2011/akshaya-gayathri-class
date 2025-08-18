using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanceTraining
{
    public class Structure
    {
        public struct Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public Employee(int id, string name, string department)
            {
                Id = id;
                Name = name;
                Department = department;
            }
            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Department: {Department}";
            }
        }

        public static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            Employee employee1;
            employee1 = new Employee(1, "John Doe", "IT");
            Employee employee2 = new Employee(2, "Jane Smith", "HR");
            employees[0] = employee1;
            employees[1] = employee2;
            employees[2] = new Employee(3, "Alice Johnson", "Finance");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
