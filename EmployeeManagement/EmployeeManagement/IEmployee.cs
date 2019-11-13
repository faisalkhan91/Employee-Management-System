using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    interface IEmployee
    {
        int EmployeeID { get; set; }
        string FullName { get; set; }
        DateTime DateOfBirth { get; set; }
        int Experience { get; set; }
        string Designation { get; set; }
        int BasicPay { get; set; }
        int GrossPay { get; set; }
    }
}
