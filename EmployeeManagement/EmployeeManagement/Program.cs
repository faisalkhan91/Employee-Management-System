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

                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter the department name you want to add: ");
                        string DName = Console.ReadLine();
                        comp.AddDepartment(DName);

                        loopContinue = true;
                        break;
                    case 2:
                        Console.Write("\nEnter your full name: ");
                        emp.FullName = Console.ReadLine();
                        Console.Write("\nEnter your date of birth: ");
                        string DOB = Console.ReadLine();
                        DateTime dt;
                        while (!DateTime.TryParseExact(DOB, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                        {
                            Console.WriteLine("Invalid date, please retry");
                            DOB = Console.ReadLine();
                        }
                        Console.Write("\nEnter your experience: ");
                        emp.Experience = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter your designation: ");
                        emp.Designation = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter your basic pay: ");
                        emp.BasicPay = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter your gross pay: ");
                        emp.GrossPay = Convert.ToInt32(Console.ReadLine());
                        
                        comp.AddEmployee(emp, out _);
                        loopContinue = true;
                        break;
                    case 3:

                        loopContinue = false;
                        break;
                    case 4:
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

                        loopContinue = false;
                        break;

                    default:
                        loopContinue = true;
                        break;
                }
                if (loopContinue)
                    Console.WriteLine("\nError: Please enter a valid choice!");
            }
        }

        static int Menu()
        {
            Console.WriteLine("\n***** EMPLOYEE MANAGEMENT SYSTEM *****");
            Console.WriteLine("1) Add Department");
            Console.WriteLine("2) Add Employee");
            Console.WriteLine("3) Edit Employee details");
            Console.WriteLine("4) View Employee details");
            Console.WriteLine("5) Remove Employee");
            Console.WriteLine("6) View Statistics");
            Console.WriteLine("7) View All Department");
            Console.Write("Please input your option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }
    }
}
