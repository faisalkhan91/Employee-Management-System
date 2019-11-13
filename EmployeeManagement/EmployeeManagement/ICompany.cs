    using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    interface ICompany
    {
        public int AddDepartment(string deptName);
        public int AddEmployee(IEmployee e, out int id);
        public int EditEmployee(int employee);
        public IEmployee ViewEmployee(int id);
        public IEmployee ViewEmployee(string name);
        public int DeleteEmployee(int id);
        public int ViewDepartment();
        public int ViewStatistics(int id);
    }
}
