using System;
using System.Collections.Generic;
using TEams.Classes;

namespace TEams
{
    class Program
    {
        static List<Department> departments = new List<Department>();
        public static List<Employee> employees = new List<Employee>();
        static Dictionary<string, Project> projects = new Dictionary<string, Project>();
        static void Main(string[] args)
        {
            // create some departments
            CreateDepartments();

            // print each department by name
            PrintDepartments();

            // create employees
            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!


            // print all employees
            PrintEmployees();

            // create the TEams project
            CreateTeamsProject();

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */
        private static void CreateDepartments()
        {
            departments.Add(new Department(001, "Marketing"));
            departments.Add(new Department(002, "Sales"));
            departments.Add(new Department(003, "Engineering"));
        }

        /**
         * Print out each department in the collection.
         */
        private static void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");
            for (int i = 0; i < departments.Count; i++)
            {
                Console.WriteLine(departments[i].Name);
            }

        }

        /**
         * Create employees and add them to the collection of employees
         */
        private static void CreateEmployees()
        {
            employees.Add(new Employee());
            employees[0].EmployeeId = 001;
            employees[0].FirstName = "Dean";
            employees[0].LastName = "Johnson";
            employees[0].Email = "djohnson@teams.com";
            employees[0].Salary = 60000;
            employees[0].Department = departments[2];
            employees[0].HireDate = "08/21/2020";
            employees.Add(new Employee(002, "Angie", "Smith", "asmith@teams.com", departments[2], "08/21/2020"));
            employees.Add(new Employee(003, "Margaret", "Thompson", "mthompson@teams.com", departments[0], "08/21/2020"));

            employees[1].Salary += .1 * employees[1].Salary;
        }

        /**
         * Print out each employee in the collection.
         */
        private static void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{employees[i].FullName} ({employees[i].Salary}) {employees[i].Department.Name}");
            }
        }

        /**
         * Create the 'TEams' project.
         */
        private static void CreateTeamsProject()
        {
            Project teams = new Project("TEams", "Project Management Software", "10/10/2020", "11/10/2020");
            teams.TeamMembers.Add(employees[0]);
            teams.TeamMembers.Add(employees[1]);
            projects.Add("TEams", teams);
        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private static void CreateLandingPageProject()
        {
            Project marketing = new Project("Marketing Landing Page", "Lead Capture Landing Page for Marketing", "10/10/2020", "11/17/2020");
            marketing.TeamMembers.Add(employees[2]);
            projects.Add("Marketing Landing Page", marketing);
        }

        /**
         * Print out each project in the collection.
         */
        private static void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");
            foreach(KeyValuePair<string, Project> name in projects)
            {
                Console.WriteLine($"{name.Key}: {name.Value.TeamMembers.Count}");
            }
        }
    }
}
