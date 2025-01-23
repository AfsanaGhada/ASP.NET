using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //7. Salary Calculation with Default Constructor

    class Salary
    {
        // Member variables
        public double Basic { get; set; }
        public double TA { get; set; } // Travel Allowance
        public double DA { get; set; } // Dearness Allowance
        public double HRA { get; set; } // House Rent Allowance

        // Constructor with default values for DA and HRA
        public Salary(double basic, double ta, double da = 10.0, double hra = 15.0)
        {
            Basic = basic;
            TA = ta;
            DA = da;
            HRA = hra;
        }

        // Method to calculate the total salary
        public double CalculateTotalSalary()
        {
            double daAmount = (Basic * DA) / 100; // DA as percentage of Basic
            double hraAmount = (Basic * HRA) / 100; // HRA as percentage of Basic
            return Basic + TA + daAmount + hraAmount;
        }

        // Method to display salary details
        public void DisplaySalaryDetails()
        {
            Console.WriteLine("\nSalary Details:");
            Console.WriteLine($"Basic Salary: {Basic:C}");
            Console.WriteLine($"Travel Allowance (TA): {TA:C}");
            Console.WriteLine($"Dearness Allowance (DA): {DA}%");
            Console.WriteLine($"House Rent Allowance (HRA): {HRA}%");
            Console.WriteLine($"Total Salary: {CalculateTotalSalary():C}");
        }
    }
}
