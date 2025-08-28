using System;

namespace CSharpTraining
{
    enum Options
    {
        Yes,
        No
    }
    public class EmployeeClass
    {
        private int _id;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _dob;
        private DateTime _doj;

        public int EmployeeId
        {
            get { return _id; }
            set { _id = value; }
        }

        public string EmployeeFirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string EmployeeMiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string EmployeeLastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime EmployeeDateOfBirth
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public DateTime EmployeeDateOfJoining
        {
            get { return _doj; }
            set { _doj = value; }
        }

        public string EmployeeFullName
        {
            get { return $"{_firstName} {_middleName} {_lastName}"; }
        }

        public EmployeeClass()
        {

        }

        public EmployeeClass(int id, string firstName, string middleName, string lastName, DateTime dob, DateTime doj)
        {
            this.EmployeeId = id;
            this.EmployeeFirstName = firstName;
            this.EmployeeMiddleName = middleName;
            this.EmployeeLastName = lastName;
            this.EmployeeDateOfBirth = dob;
            this.EmployeeDateOfJoining = doj;
        }

        ~EmployeeClass()
        {
            Console.WriteLine("Program Execution Completed");
        }

        public string GetEmployeeDetailString()
        {
            return $"Employee Id: {this.EmployeeId}\nEmployee First Name: {this.EmployeeFirstName}\nEmployee Middle Name: {this.EmployeeMiddleName}\nEmployee Last Name: {this.EmployeeLastName}\nEmployee Full Name:{this.EmployeeFullName}\nEmployee Date of Birth:{this.EmployeeDateOfBirth}\nEmployee Date Of Joining: {this.EmployeeDateOfJoining}";
        }

    }

    public class EmployeeMain
    {
        public static void Main(string[] args)
        {
            int _id = 0;
            EMPLOYEE_INITIALIZE:
                _id++;
                Console.Write("Enter the First Name:");
                string firstName = Console.ReadLine();
                Console.Write("Enter the Middle Name:");
                string middleName = Console.ReadLine();
                Console.Write("Enter the Last Name:");
                string lastName = Console.ReadLine();
                Console.Write("Enter the Date Of Birth:");
                DateTime.TryParse(Console.ReadLine(), out DateTime dob);
                Console.Write("Enter the Date Of Joining:");
                DateTime.TryParse(Console.ReadLine(), out DateTime doj);

                EmployeeClass employee = new EmployeeClass(_id, firstName, middleName, lastName, dob, doj);
                Console.WriteLine("Following are the Employee Details:");
                Console.WriteLine(employee.GetEmployeeDetailString());

                Console.WriteLine("Do you want to enter another Employee? Type Yes or No:");
                Enum.TryParse(typeof(Options), Console.ReadLine(), out object option);
                if (((Options)option) == Options.Yes)
                    goto EMPLOYEE_INITIALIZE;

        }
    }
}
