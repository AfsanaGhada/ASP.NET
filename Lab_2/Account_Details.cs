using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    ///6. Single Inheritance (Account and Interest
    class Account_Details
    {
        // Data members
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double PrincipalAmount { get; set; }
        public double RateOfInterest { get; set; }
        public int TimeInYears { get; set; }

        // Method to get account details
        public void GetAccountDetails()
        {
            Console.Write("Enter Account Number: ");
            AccountNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Account Holder Name: ");
            AccountHolderName = Console.ReadLine();
            Console.Write("Enter Principal Amount: ");
            PrincipalAmount = double.Parse(Console.ReadLine());
            Console.Write("Enter Rate of Interest (in %): ");
            RateOfInterest = double.Parse(Console.ReadLine());
            Console.Write("Enter Time Period (in years): ");
            TimeInYears = int.Parse(Console.ReadLine());
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder Name: {AccountHolderName}");
            Console.WriteLine($"Principal Amount: {PrincipalAmount:C}");
            Console.WriteLine($"Rate of Interest: {RateOfInterest}%");
            Console.WriteLine($"Time Period: {TimeInYears} years");
        }
    }

    // Derived class: Interest
    class Interest : Account_Details
    {
        // Method to calculate total interest
        public double CalculateInterest()
        {
            return (PrincipalAmount * RateOfInterest * TimeInYears) / 100;
        }

        // Method to display total interest
        public void DisplayTotalInterest()
        {
            double totalInterest = CalculateInterest();
            Console.WriteLine($"\nTotal Interest: {totalInterest:C}");
        }
    }
}
