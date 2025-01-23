using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //9. Furniture and Table (Single Inheritance
    class Furniture
    {
        // Data members
        public string Material { get; set; }
        public double Price { get; set; }

        // Constructor to initialize material and price
        public Furniture(string material, double price)
        {
            Material = material;
            Price = price;
        }

        // Method to display Furniture details
        public void DisplayFurnitureDetails()
        {
            Console.WriteLine($"Material: {Material}");
            Console.WriteLine($"Price: {Price:C}");
        }
    }

    // Derived class: Table
    class Table : Furniture
    {
        // Additional data members for Table
        public double Height { get; set; }
        public double SurfaceArea { get; set; }

        // Constructor to initialize all data members (calls the base class constructor)
        public Table(string material, double price, double height, double surfaceArea)
            : base(material, price)
        {
            Height = height;
            SurfaceArea = surfaceArea;
        }

        // Method to display Table details
        public void DisplayTableDetails()
        {
            Console.WriteLine("\nTable Details:");
            DisplayFurnitureDetails(); // Calling base class method to display Furniture details
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"Surface Area: {SurfaceArea} sq. cm");
        }
    }
}
