using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    class Department : IDepartment
    {
        private int _departmentID;
        private string _departmentName;
        public Department()
        {
            DepartmentID = 0;
            DepartmentName = null;
        }
        public Department(int departmentId, string departmentName)
        {
            DepartmentID = departmentId;
            DepartmentName = departmentName;
        }

        public int DepartmentID { get => _departmentID; set => _departmentID = value; }
        public string DepartmentName { get => _departmentName; set => _departmentName = value; }
    }
}
