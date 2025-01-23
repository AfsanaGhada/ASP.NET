using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //8. Distance Addition
    class Distance
    {
        // Data members
        public double dist1 { get; set; }
        public double dist2 { get; set; }
        public double dist3 { get; set; }

        // Constructor to initialize dist1 and dist2
        public Distance(double distance1, double distance2)
        {
            dist1 = distance1;
            dist2 = distance2;
        }

        // Method to calculate the sum of dist1 and dist2, store it in dist3
        public void CalculateDistanceSum()
        {
            dist3 = dist1 + dist2;
        }

        // Method to display the sum of distances
        public void DisplayDistanceSum()
        {
            Console.WriteLine($"\nSum of distances: {dist1} + {dist2} = {dist3}");
        }
    }
}
