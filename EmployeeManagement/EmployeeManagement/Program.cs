using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopContinue = true;
            int choice = 0;

            Company comp = new Company();
            IEmployee emp = new Employee();

            while (loopContinue)
            {

                choice = Menu();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("******** ADD DEPARTMENT ********");
                        Console.WriteLine();
                        Console.Write("\nEnter the department name you want to add: ");
                        string DName = Console.ReadLine();
                        comp.AddDepartment(DName);

                        loopContinue = true;
                        break;
                    case 2:
                        Console.WriteLine("******** ADD EMPLOYEE ********");
                        Console.WriteLine();
                        Console.WriteLine("List of available Departments:");
                        comp.ViewDepartment();
                        Console.Write("Please input one of the above department ID for the new employee: ");
                        emp.EmployeeDepID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You selected Department ID: " + emp.EmployeeDepID + ". Please enter the employee details below.\n");
                        Console.Write("Enter your full name: ");
                        emp.FullName = Console.ReadLine();
                        Console.Write("Enter employee date of birth (Format - MM/DD/YYYY): ");
                        string DOB = Console.ReadLine();
                        DateTime dt;
                        while (!DateTime.TryParseExact(DOB, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                        {
                            Console.WriteLine("Invalid date, please retry");
                            DOB = Console.ReadLine();
                        }
                        emp.DateOfBirth = dt;
                        Console.Write("Enter your experience: ");
                        emp.Experience = Convert.ToInt32(Console.ReadLine());
                        emp.Designation = "";
                        while (emp.Designation != "Manager" && emp.Designation != "Employee")
                        {
                            Console.Write("Enter your designation: ");
                            emp.Designation = Console.ReadLine();
                        }
                        Console.Write("Enter your basic pay: ");
                        emp.BasicPay = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter your gross pay: ");
                        emp.GrossPay = Convert.ToInt32(Console.ReadLine());
                        
                        comp.AddEmployee(emp, out _);
                        loopContinue = true;
                        break;
                    case 3:
                        Console.WriteLine("******** EDIT EMPLOYEE DETAILS ********");
                        Console.WriteLine();

                        Console.Write("\nEnter the ID to change designation for: ");
                        int desgID = Convert.ToInt32(Console.ReadLine());
                        comp.EditEmployee(desgID);

                        loopContinue = true;
                        break;
                    case 4:
                        Console.WriteLine("******** VIEW EMPLOYEE DETAILS ********");
                        Console.WriteLine();
                        Console.Write("Do you want to search usign (ID) or (Name)? ");
                        string searchParameter = Console.ReadLine();
                        if (searchParameter == "ID" || searchParameter == "id" || searchParameter == "Id")
                        {
                            Console.Write("\nEnter the employee ID to search for: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            comp.ViewEmployee(id);
                        }
                        else
                        {
                            Console.Write("\nEnter the employee full name to search for: ");
                            string name = Console.ReadLine();
                            comp.ViewEmployee(name);
                        }

                        loopContinue = true;
                        break;
                    case 5:
                        Console.WriteLine("******** REMOVE EMPLOYEE ********");
                        Console.WriteLine();
                        Console.WriteLine("Enter the ID of the employee you want to remove: ");
                        int empid = Convert.ToInt32(Console.ReadLine());
                        comp.DeleteEmployee(empid);

                        loopContinue = true;
                        break;
                    case 6:
                        Console.WriteLine("******** VIEW STATISTICS ********");
                        Console.WriteLine();

                        Console.WriteLine("List of available Departments:");
                        comp.ViewDepartment();
                        Console.Write("\nEnter the Department ID to display statistics for: ");
                        int did = Convert.ToInt32(Console.ReadLine());
                        comp.ViewStatistics(did);
                        break;
                    case 7:
                        Console.WriteLine("******** VIEW ALL DEPARTMENT ********");
                        Console.WriteLine();
                        comp.ViewDepartment();
                        loopContinue = true;
                        break;
                    case 8:
                        Console.WriteLine("******** EXITING ********");
                        Console.WriteLine();
                        Console.WriteLine("Program exited...");
                        loopContinue = false;
                        break;

                    default:
                        loopContinue = true;
                        break;
                }
                if (loopContinue)
                    Console.WriteLine("\nReturning to main menu.");
                    Console.WriteLine();
            }
        }

        static int Menu()
        {
            Console.WriteLine("\n***** EMPLOYEE MANAGEMENT SYSTEM *****");
            Console.WriteLine();
            Console.WriteLine("1) Add Department");
            Console.WriteLine("2) Add Employee");
            Console.WriteLine("3) Edit Employee details");
            Console.WriteLine("4) View Employee details");
            Console.WriteLine("5) Remove Employee");
            Console.WriteLine("6) View Statistics");
            Console.WriteLine("7) View All Department");
            Console.WriteLine("8) Exit");
            Console.WriteLine();
            Console.Write("Please input your option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }
    }
}
