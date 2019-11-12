using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    class Employee : Department, IEmployee
    {
        private int _employeeID;
        private string _fullName;
        private DateTime _dateOfBirth;
        private int _experience;
        private int _designation;
        private int _basicPay;
        private int _grossPay;

        public Employee()
        {
            EmployeeID = 0;
            FullName = null;
            DateOfBirth = DateTime.Now;
            Experience = 0;
            Designation = 0;
            BasicPay = 0;
            GrossPay = 0;
        }
        public Employee(int employeeID, string fullName, DateTime dateOfBirth, int experience, int designation, int basicPay, int grossPay)
        {
            EmployeeID = employeeID;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Experience = experience;
            Designation = designation;
            BasicPay = basicPay;
            GrossPay = grossPay;
        }

        public int EmployeeID { get => _employeeID; set => _employeeID = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public int Experience { get => _experience; set => _experience = value; }
        public int Designation { get => _designation; set => _designation = value; }
        public int BasicPay { get => _basicPay; set => _basicPay = value; }
        public int GrossPay { get => _grossPay; set => _grossPay = value; }
    }
}
