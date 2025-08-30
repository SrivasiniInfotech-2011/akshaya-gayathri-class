using CharpAdvance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSharpAdvanceTraining
{
    public class CustomerSearchProgram
    {
        public static void Main(string[] args)
        {
            var customerJsonData = File.ReadAllText("CustomerData.json");
            var customers = JsonSerializer.Deserialize<List<Customer>>(customerJsonData);
           // SearchCustomersByName(customers, "jane", new Func<Customer, string, bool>(CheckName));
           // var matchedCustomers = customers.Where(customer => customer.DateOfBirth >= new DateTime(1953, 1, 1) && customer.DateOfBirth <= new DateTime(2000, 12, 31)).ToList();
           //customers
           //     .Where(s=>s.FirstName.Contains("Jane",StringComparison.OrdinalIgnoreCase))
           //     .Select(c=>c.Name).ToList()
           //     .ForEach(name=>Console.WriteLine(name));
           if(customers.Any(c => c.FirstName.Contains("Jane", StringComparison.OrdinalIgnoreCase)))
                Console.Write("Jane, you are shortlisted!");
            if (customers.All(c => c.FirstName.Contains("Jane", StringComparison.OrdinalIgnoreCase)))
                Console.Write("Jane, you are shortlisted!");
            var maleCount = customers.GroupBy(s => s.Gender);
        }

        public static List<Customer> SearchCustomersByName(List<Customer> customers, string name,Func<Customer,string,bool> searchDelegate)
        {
            var matchedCustomers = new List<Customer>();
            foreach (var customer in customers)
            {
                if (searchDelegate(customer,name))
                {
                    matchedCustomers.Add(customer);
                }
            }
            return matchedCustomers;
        }

        public static bool CheckName(Customer customer, string name)
        {
            return customer.FirstName != null && customer.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                    customer.LastName != null && customer.LastName.Contains(name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
