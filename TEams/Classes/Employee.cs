using System;
using System.Collections.Generic;
using System.Text;

namespace TEams.Classes
{
    public class Employee
    {
        public long EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        public string HireDate { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
        private const double StartingSalary = 60000.00;

        public Employee(long employeeId, string firstName, string lastName, string email, Department department, string hireDate)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Department = department;
            this.HireDate = hireDate;
        }

    }
}
