using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement
{
    class Company : Employee, ICompany
    {
        List<Department> DepartmentList = new List<Department>();
        List<Employee> EmployeeList = new List<Employee>();

        //List<Company> CompanyList = new List<Company>();

        public int AddDepartment(string deptName)
        {
            int i = 1;
            Random random = new Random();
            int rnd = random.Next(1152);

            DepartmentList.Add(new Department(rnd, deptName));
            Console.WriteLine();

            foreach (var department in DepartmentList)
            {
                Console.WriteLine(i + ")" + " Department ID: " + department.DepartmentID + " | Department Name: " + department.DepartmentName);
                i++;
            }

            return rnd;
        }

        public int AddEmployee(IEmployee e, out int id)
        {
            int i = 1;
            Random random = new Random();
            int rnd = random.Next(1152342);

            EmployeeList.Add(new Employee(e.EmployeeDepID, rnd, e.FullName, e.DateOfBirth, e.Experience, e.Designation, e.BasicPay, e.GrossPay));
            Console.WriteLine();

            foreach (var employee in EmployeeList)
            {
                Console.WriteLine("********* Employee " + i + " *********");
                Console.WriteLine("Department ID: " + employee.EmployeeDepID);
                Console.WriteLine("Employee ID: " + employee.EmployeeID);
                Console.WriteLine("Name: " + employee.FullName);
                Console.WriteLine("DOB: " + employee.DateOfBirth);
                Console.WriteLine("Experience: " + employee.Experience);
                Console.WriteLine("Designation: " + employee.Designation);
                Console.WriteLine("Basic Pay: " + employee.BasicPay);
                Console.WriteLine("Gross Pay: " + employee.GrossPay);
                Console.WriteLine();
                i++;
            }

            id = rnd;
            return rnd;
        }

        public int EditEmployee(int employee)
        {
            Console.Write("Enter the new designation: ");
            string desig = Console.ReadLine();
            List<Employee> results = EmployeeList.FindAll(x => x.EmployeeID == employee);
            foreach (var empl in results)
            {
                empl.Designation = desig;
            }
            return 0;
        }

        public IEmployee ViewEmployee(int id)
        {
            int i = 1;
            Console.WriteLine();
            EmployeeList.Sort();
            List<Employee> results = EmployeeList.FindAll(x => x.EmployeeID == id);
            foreach (var employee in results)
            {
                Console.WriteLine("********* Employee " + i + " *********");
                Console.WriteLine("Department ID: " + employee.EmployeeDepID);
                Console.WriteLine("Employee ID: " + employee.EmployeeID);
                Console.WriteLine("Name: " + employee.FullName);
                Console.WriteLine("DOB: " + employee.DateOfBirth);
                Console.WriteLine("Experience: " + employee.Experience);
                Console.WriteLine("Designation: " + employee.Designation);
                Console.WriteLine("Basic Pay: " + employee.BasicPay);
                Console.WriteLine("Gross Pay: " + employee.GrossPay);
                Console.WriteLine();
                i++;
            }

            return null;
        }

        public IEmployee ViewEmployee(string name)
        {
            int i = 1;
            Console.WriteLine();
            EmployeeList.Sort();
            List<Employee> results = EmployeeList.FindAll(x => x.FullName == name);
            foreach (var employee in results)
            {
                //Console.WriteLine("Employee => ID: " + employee.EmployeeID + " | Name: " + employee.FullName
                //    + " | DOB: " + employee.DateOfBirth + " | Experience: " + employee.Experience + " | Designation: " + employee.Designation
                //    + " | Basic Pay: " + employee.BasicPay + " | Gross Pay: " + employee.GrossPay);
                Console.WriteLine("********* Employee " + i + " *********");
                Console.WriteLine("Department ID: " + employee.EmployeeDepID);
                Console.WriteLine("Employee ID: " + employee.EmployeeID);
                Console.WriteLine("Name: " + employee.FullName);
                Console.WriteLine("DOB: " + employee.DateOfBirth);
                Console.WriteLine("Experience: " + employee.Experience);
                Console.WriteLine("Designation: " + employee.Designation);
                Console.WriteLine("Basic Pay: " + employee.BasicPay);
                Console.WriteLine("Gross Pay: " + employee.GrossPay);
                Console.WriteLine();
                i++;
            }

            return null;
        }

        public int DeleteEmployee(int id)
        {
            var itemToRemove = EmployeeList.SingleOrDefault(r => r.EmployeeID == id);
            if (itemToRemove != null)
            {
                EmployeeList.Remove(itemToRemove);
                Console.WriteLine("Employee " + id + " is removed!");
                return id;
            }
            else
                return 0;
        }

        public int ViewDepartment()
        {
            int i = 1;
            Console.WriteLine();
            foreach (var department in DepartmentList)
            {
                Console.WriteLine(i + ")" + " Department => ID: " + department.DepartmentID + " | Name: " + department.DepartmentName);
                i++;
            }
            return 0;
        }
        public int ViewStatistics(int id)
        {
            int i = 1;
            EmployeeList.Sort();
            List<Employee> results = EmployeeList.FindAll(x => x.EmployeeDepID == id);

            foreach (var employee in EmployeeList)
            {
                Console.WriteLine("********* Employee " + i + " *********");
                Console.WriteLine("Department ID: " + employee.EmployeeDepID);
                Console.WriteLine("Employee ID: " + employee.EmployeeID);
                Console.WriteLine("Name: " + employee.FullName);
                Console.WriteLine("DOB: " + employee.DateOfBirth);
                Console.WriteLine("Experience: " + employee.Experience);
                Console.WriteLine("Designation: " + employee.Designation);
                Console.WriteLine("Basic Pay: " + employee.BasicPay);
                Console.WriteLine("Gross Pay: " + employee.GrossPay);
                Console.WriteLine();
                i++;
            }
            return 0;
        }
    }
}
