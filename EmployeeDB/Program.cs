// Kyle Riner
// Cs2 assignment, EmployeeDB program
// TINFO-200A, Winter 2022

//////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date         Developer   Description of change
// 02-07-2022   kriner      Creation of file, creation of employee objects, creation of employeeYearly
// 02-07-2022   kriner      Creation of employeeRaise variables, initial testing
// 02-09-2022   kriner      Removal of employeeYearly and employeeRaise variables, written into WriteLine calls instead
// 02-11-2022   kriner      Program documentation, creation of UI, final testing
//
// The EmployeeDB program initializes three employee objects with a first name, last name, and their
// monthly salary. The program then outputs each employee's first name, last name, and their yearly
// salary. Afterwards, the program outputs each employee's first name, last name, and their yearly salary
// after being given a ten percent raise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the namespace of the EmployeeDB program
namespace EmployeeDB
{
    // declaration of the class that holds the EmployeeTest program
    internal class Program
    {
        // the main method that executes the code of the EmployeeTest program
        static void Main(string[] args)
        {
            // user interface for program
            Console.WriteLine(@"
Welcome to the EmployeeDB program! This program reads in the first name, 
last name, and monthly salary of three employees. The program then outputs
the employees' first and last names along with their yearly salary. Finally,
each employee is given a 10 percent raise and have their first and last names
outputted along with their new yearly pay after the raise.
");

            // initialization of three employee objects
            Employee employee1 = new Employee("John", "Smith", -5555M);
            Employee employee2 = new Employee("Jane", "Doe", 6166M);
            Employee employee3 = new Employee("Freddy", "Fazbear", 7500M);

            // Output of employee yearly salaries in (firstname lastname salary) format
            Console.WriteLine("Employees Yearly Salary: ");
            Console.WriteLine($"{employee1.FirstName} {employee1.LastName} {employee1.MonthlySalary * 12M:C}");
            Console.WriteLine($"{employee2.FirstName} {employee2.LastName} {employee2.MonthlySalary * 12M:C}");
            Console.WriteLine($"{employee3.FirstName} {employee3.LastName} {employee3.MonthlySalary * 12M:C}");
            // Output of employee yearly salaries with a ten percent raise in (firstname lastname salary) format
            Console.WriteLine("\nEmployees Yearly Salary After 10% Raise: ");
            Console.WriteLine($"{employee1.FirstName} {employee1.LastName} {(employee1.MonthlySalary * 12M) * 1.1M:C}");
            Console.WriteLine($"{employee2.FirstName} {employee2.LastName} {(employee2.MonthlySalary * 12M) * 1.1M:C}");
            Console.WriteLine($"{employee3.FirstName} {employee3.LastName} {(employee3.MonthlySalary * 12M) * 1.1M:C}");

            // sign off at program termination
            Console.WriteLine("\nThank you for using the EmployeeDB program!");
        }
    }
}
