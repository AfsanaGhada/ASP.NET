using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Student
    {
        // Data members
        public string Enrollment_No { get; set; }
        public string Student_Name { get; set; }
        public int Semester { get; set; }
        public double CPI { get; set; }
        public double SPI { get; set; }

        // Constructor to get student details
        public Student(string enrollmentNo, string studentName, int semester, double cpi, double spi)
        {
            Enrollment_No = enrollmentNo;
            Student_Name = studentName;
            Semester = semester;
            CPI = cpi;
            SPI = spi;
        }

        // Method to display student details
        public void DisplayStudentDetails()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Enrollment No: {Enrollment_No}");
            Console.WriteLine($"Name: {Student_Name}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"CPI: {CPI:F2}");
            Console.WriteLine($"SPI: {SPI:F2}");
        }
    }
}
