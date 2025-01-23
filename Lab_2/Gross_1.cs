using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal interface Gross
    {
        void Gross_sal();
    }
    class Sal : Gross
    {
        public double HRA, TA, DA;

        public void Disp_sal()
        {
            Console.Write("Enter HRA: ");
            HRA = double.Parse(Console.ReadLine());

            Console.Write("Enter TA: ");
            TA = double.Parse(Console.ReadLine());

            Console.Write("Enter DA: ");
            DA = double.Parse(Console.ReadLine());
        }

        public void Gross_sal()
        {
            double grossSalary = HRA + TA + DA;
            Console.WriteLine($"Gross Salary: {grossSalary}");
        }
    }

    class Employee : Sal
    {
        public string Name;
        public double Basic_Salary;

        public void basic_sal()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            Basic_Salary = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Basic Salary: {Basic_Salary}");
        }
    }
}

