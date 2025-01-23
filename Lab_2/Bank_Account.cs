using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Bank_Account
    {
        // Data members
        public int Account_No { get; set; }
        public string Email { get; set; }
        public string User_Name { get; set; }
        public string Account_Type { get; set; }
        public double Account_Balance { get; set; }

        // Method to get account details
        public void GetAccountDetails()
        {
            Console.Write("Enter Account Number: ");
            Account_No = int.Parse(Console.ReadLine());
            Console.Write("Enter Email Address: ");
            Email = Console.ReadLine();
            Console.Write("Enter User Name: ");
            User_Name = Console.ReadLine();
            Console.Write("Enter Account Type (e.g., Savings/Current): ");
            Account_Type = Console.ReadLine();
            Console.Write("Enter Account Balance: ");
            Account_Balance = double.Parse(Console.ReadLine());
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine($"Account Number: {Account_No}");
            Console.WriteLine($"Email Address: {Email}");
            Console.WriteLine($"User Name: {User_Name}");
            Console.WriteLine($"Account Type: {Account_Type}");
            Console.WriteLine($"Account Balance: {Account_Balance:C}");
        }
    }

}
