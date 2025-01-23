using System;
using Lab_2;

namespace Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select a program to execute (1-10) or 0 to exit:");
                Console.WriteLine("1. Candidate Details");
                Console.WriteLine("2. Staff Details");
                Console.WriteLine("3. Bank Account Details");
                Console.WriteLine("4. Student Details");
                Console.WriteLine("5. Area of Rectangle");
                Console.WriteLine("6. Single Inheritance (Account and Interest)");
                Console.WriteLine("7. Salary Calculation with Default Constructor");
                Console.WriteLine("8. Distance Addition");
                Console.WriteLine("9. Furniture and Table (Single Inheritance)");
                Console.WriteLine("10. Multiple Inheritance Using Interface");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Exiting the program.");
                        break;

                    case 1:
                        Console.WriteLine("Candidate Details Program\n");

                        Candidate candidate = new Candidate();

                        candidate.GetCandidateDetails();

                        candidate.DisplayCandidateDetails();

                        Console.WriteLine("\nProgram executed successfully!"); break;

                    case 2:
                        Console.WriteLine("Staff Details Program\n");

                        // Create an array to hold 5 staff members
                        Staff[] staffs = new Staff[5];

                        // Input details for 5 staff members
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"\nEnter details for Staff {i + 1}:");
                            staffs[i] = new Staff();
                            staffs[i].GetStaffDetails();
                        }

                        // Display HOD details
                        Console.WriteLine("\nDetails of HODs:");
                        bool hodFound = false;
                        foreach (var staff in staffs)
                        {
                            if (staff.Designation.ToLower() == "hod")
                            {
                                hodFound = true;
                                staff.DisplayHODDetails();
                            }
                        }

                        if (!hodFound)
                        {
                            Console.WriteLine("No HODs found.");
                        }

                        Console.WriteLine("\nProgram executed successfully!");
                
                break;

                    case 3:
                        Console.WriteLine("Bank Account Details Program\n");

                        Bank_Account account = new Bank_Account();

                        account.GetAccountDetails();

                        account.DisplayAccountDetails();

                        Console.WriteLine("\nProgram executed successfully!");
                        break;

                    case 4:
                        Console.WriteLine("Student Details Program\n");

                        // Get student details from the user
                        Console.Write("Enter Enrollment Number: ");
                        string enrollmentNo = Console.ReadLine();
                        Console.Write("Enter Student Name: ");
                        string studentName = Console.ReadLine();
                        Console.Write("Enter Semester: ");
                        int semester = int.Parse(Console.ReadLine());
                        Console.Write("Enter CPI: ");
                        double cpi = double.Parse(Console.ReadLine());
                        Console.Write("Enter SPI: ");
                        double spi = double.Parse(Console.ReadLine());

                        // Create a Student object using the constructor
                        Student student = new Student(enrollmentNo, studentName, semester, cpi, spi);

                        // Display the student details
                        student.DisplayStudentDetails();

                        Console.WriteLine("\nProgram executed successfully!");
                        break;

                    case 5:
                        Console.WriteLine("Rectangle Area Calculation Program\n");

                        Console.Write("Enter the Length of the Rectangle: ");
                        double length = double.Parse(Console.ReadLine());
                        Console.Write("Enter the Width of the Rectangle: ");
                        double width = double.Parse(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(length, width);

                        double area = rectangle.CalculateArea();
                        Console.WriteLine($"\nThe Area of the Rectangle is: {area:F2}");

                        Console.WriteLine("\nProgram executed successfully!");
                        break;

                    case 6:
                        Console.WriteLine("Account and Interest Calculation Program\n");

                        // Create an instance of the derived class
                        Interest interestAccount = new Interest();

                        // Get account details
                        interestAccount.GetAccountDetails();

                        // Display account details
                        interestAccount.DisplayAccountDetails();

                        // Display total interest
                        interestAccount.DisplayTotalInterest();

                        Console.WriteLine("\nProgram executed successfully!");

                        break;

                    case 7:
                        Console.WriteLine("Salary Calculation Program\n");

                        // Get employee details from the user
                        Console.Write("Enter Basic Salary: ");
                        double basic = double.Parse(Console.ReadLine());
                        Console.Write("Enter Travel Allowance (TA): ");
                        double ta = double.Parse(Console.ReadLine());

                        // Create a Salary object using the constructor
                        Salary employeeSalary = new Salary(basic, ta);

                        // Display the salary details
                        employeeSalary.DisplaySalaryDetails();

                        Console.WriteLine("\nProgram executed successfully!");
                
                break;

                    case 8:
                        Console.WriteLine("Distance Addition Program\n");

                        // Get distances from the user
                        Console.Write("Enter the first distance (dist1): ");
                        double distance1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter the second distance (dist2): ");
                        double distance2 = double.Parse(Console.ReadLine());

                        // Create an instance of the Distance class
                        Distance distanceObj = new Distance(distance1, distance2);

                        // Calculate and display the sum of distances
                        distanceObj.CalculateDistanceSum();
                        distanceObj.DisplayDistanceSum();

                        Console.WriteLine("\nProgram executed successfully!");
                        break;

                    case 9:
                        Console.WriteLine("Furniture and Table Program\n");

                        // Creating an object of Table (derived class)
                        Table table = new Table("Wood", 2500.50, 75.0, 1500.0);

                        // Displaying the details of the table
                        table.DisplayTableDetails();

                        Console.WriteLine("\nProgram executed successfully!");
                        break;

                    case 10:
                       
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
       
    }

}
