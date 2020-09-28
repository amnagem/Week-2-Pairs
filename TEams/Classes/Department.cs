using System;
using System.Collections.Generic;
using System.Text;

namespace TEams.Classes
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public Department(int departmentId, string name)
        {
            this.DepartmentId = departmentId;
            this.Name = name;
        }
    }
}
