using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create each employee first and last name with id
            List<Employee> Employee = new List<Employee>();
            Employee Emp1 = new Employee();
            Emp1.FirstName = "Albert";
            Emp1.LastName = "Tulo";
            Emp1.Id = 1;

            Employee Emp2 = new Employee();
            Emp2.FirstName = "Joe";
            Emp2.LastName = "Shmo";
            Emp2.Id = 2;

            Employee Emp3 = new Employee();
            Emp3.FirstName = "John";
            Emp3.LastName = "Smith";
            Emp3.Id = 3;

            Employee Emp4 = new Employee();
            Emp4.FirstName = "Eddy";
            Emp4.LastName = "Mackerson";
            Emp4.Id = 4;

            Employee Emp5 = new Employee();
            Emp5.FirstName = "Johnny";
            Emp5.LastName = "Bravo";
            Emp5.Id = 5;

            Employee Emp6 = new Employee();
            Emp6.FirstName = "Timmy";
            Emp6.LastName = "Turner";
            Emp6.Id = 6;

            Employee Emp7 = new Employee();
            Emp7.FirstName = "Joe";
            Emp7.LastName = "Rogan";
            Emp7.Id = 7;

            Employee Emp8 = new Employee();
            Emp8.FirstName = "Spongebob";
            Emp8.LastName = "Squarepants";
            Emp8.Id = 8;

            Employee Emp9 = new Employee();
            Emp9.FirstName = "Lewis";
            Emp9.LastName = "Hamilton";
            Emp9.Id = 9;

            Employee Emp10 = new Employee();
            Emp10.FirstName = "Maxwel";
            Emp10.LastName = "Verstrapen";
            Emp10.Id = 10;

            //create new list for all the employees
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(Emp1);
            EmployeeList.Add(Emp2);
            EmployeeList.Add(Emp3);
            EmployeeList.Add(Emp4);
            EmployeeList.Add(Emp5);
            EmployeeList.Add(Emp6);
            EmployeeList.Add(Emp7);
            EmployeeList.Add(Emp8);
            EmployeeList.Add(Emp9);
            EmployeeList.Add(Emp10);

            //looking for all employees with the first name of joe
            List<Employee> anewList = new List<Employee>();
            foreach (Employee employee in EmployeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    anewList.Add(employee);
                }
            }
            Console.WriteLine("Employee named \"Joe\" has been found.");

            
            for (int i = 0; i < anewList.Count; i++)
            {
                Console.WriteLine(anewList[i].FirstName + " " + anewList[i].LastName + "\n");
            }

            List<Employee> anewList1 = EmployeeList.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("Employees named \"Joe\" include:");
            for (int j = 0; j < anewList1.Count; j++)
            {
                Console.WriteLine(anewList1[j].FirstName + " " + anewList1[j].LastName + "\n");
            }

            List<Employee> fivePlus = EmployeeList.Where(x => x.Id > 5).ToList();
            Console.WriteLine("Employees with an Id greater than 5 include: ");
            for (int k = 0; k < fivePlus.Count; k++)
            {
                Console.WriteLine(fivePlus[k].FirstName + " " + fivePlus[k].LastName + "\n");
            }
            Console.ReadLine();
        }
    }
}
