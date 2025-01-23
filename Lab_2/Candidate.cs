using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Candidate
    {
        // Data members
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        // Method to get candidate details
        public void GetCandidateDetails()
        {
            Console.Write("Enter Candidate ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Candidate Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Candidate Age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Candidate Weight (kg): ");
            Weight = double.Parse(Console.ReadLine());
            Console.Write("Enter Candidate Height (cm): ");
            Height = double.Parse(Console.ReadLine());
        }

        // Method to display candidate details
        public void DisplayCandidateDetails()
        {
            Console.WriteLine("\nCandidate Details:");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Height: {Height} cm");
        }
    }
}
