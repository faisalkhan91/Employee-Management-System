using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    interface IDepartment
    {
        int DepartmentID { get ; set ; }
        string DepartmentName { get; set; }
    }
}
