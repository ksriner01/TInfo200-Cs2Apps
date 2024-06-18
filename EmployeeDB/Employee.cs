// Kyle Riner
// Cs2 assignment, EmployeeDB program
// TINFO-200A, Winter 2022

//////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date         Developer   Description of change
// 02-07-2022   kriner      Creation of file, creation of constructor, creation of MonthlySalary get and set block, ToString overrided
// 02-11-2022   kriner      Documentation of file
//
// The Employee class of the EmployeeDB program constructs an employee object with parameters for a first name,
// last name, and monthly salary. The monthly salary's get and set block is explicitly declared because the
// monthly salary should be set to its default value if the code attempts to set it to negative.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the namespace for the EmployeeDB program
namespace EmployeeDB
{
    // declaration of the class that holds the Employee program
    internal class Employee
    {
        // initialization of Employee constructor parameters
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal monthlySalary;

        // Employee constructor used to create Employee objects that take in 
        // a first name, last name, and monthly salary
        public Employee(string firstname, string lastname, decimal monthlySalary)
        {
            FirstName = firstname;
            LastName = lastname;
            MonthlySalary = monthlySalary;
        }

        // MonthlySalary property with set block that leaves the variable
        // unchanged if given a negative value
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value > 0.0M)
                {
                    monthlySalary = value;
                }
            }
        }

        // overrides the ToString method in order to output employee objects as strings
        public override string ToString()
        {
            return $"{FirstName} {LastName} {MonthlySalary:C}";
        }
    }
}
