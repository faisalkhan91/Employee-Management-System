using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    class Company : Employee
    {
        List<Department> DepartmentList = new List<Department>();
        List<Employee> EmployeeList = new List<Employee>();

        //List<Company> CompanyList = new List<Company>();

        public int AddDepartment(string deptName)
        {
            Random random = new Random();
            int rnd = random.Next(1152);

            DepartmentList.Add(new Department(rnd, deptName));
            Console.WriteLine();

            foreach (var department in DepartmentList)
            {
                Console.WriteLine("Department ID: " + department.DepartmentID + " | Department Name: " + department.DepartmentName);
            }

            return rnd;
        }

        public int AddEmployee(IEmployee e, out int id)
        {
            Random random = new Random();
            int rnd = random.Next(1152342);

            EmployeeList.Add(new Employee(rnd, e.FullName, e.DateOfBirth, e.Experience, e.Designation, e.BasicPay, e.GrossPay));
            Console.WriteLine();

            foreach (var employee in EmployeeList)
            {
                Console.WriteLine("Employee => ID: " + employee.EmployeeID + " | Name: " + employee.FullName
                    + " | DOB: " + employee.DateOfBirth + " | Experience: " + employee.Experience + " | Designation: " + employee.Designation
                    + " | Basic Pay: " + employee.BasicPay + " | Gross Pay: " + employee.GrossPay);
            }

            id = rnd;
            return rnd;
        }

        int EditEmployee(int employee)
        {
            return 0;
        }

        public IEmployee ViewEmployee(int id)
        {
            EmployeeList.Sort();
            List<Employee> results = EmployeeList.FindAll(x => x.EmployeeID == id);
            foreach (var employee in results)
            {
                Console.WriteLine("Employee => ID: " + employee.EmployeeID + " | Name: " + employee.FullName
                    + " | DOB: " + employee.DateOfBirth + " | Experience: " + employee.Experience + " | Designation: " + employee.Designation
                    + " | Basic Pay: " + employee.BasicPay + " | Gross Pay: " + employee.GrossPay);
            }

            return null;
        }

        public IEmployee ViewEmployee(string name)
        {
            EmployeeList.Sort();
            List<Employee> results = EmployeeList.FindAll(x => x.FullName == name);
            foreach (var employee in results)
            {
                Console.WriteLine("Employee => ID: " + employee.EmployeeID + " | Name: " + employee.FullName
                    + " | DOB: " + employee.DateOfBirth + " | Experience: " + employee.Experience + " | Designation: " + employee.Designation
                    + " | Basic Pay: " + employee.BasicPay + " | Gross Pay: " + employee.GrossPay);
            }

            return null;
        }

        public int DeleteEmployee(int id)
        {
            return 0;
        }

        int ViewStatistics(int id)
        {
            return 0;
        }
    }
}
