using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Three
{
        public  interface Shape { 
             double Cirle(double radius);
             double Traingle(double bases,double height);
             double Square(double side);
        }

        public class CalculateShape : Shape
        {
            public double Cirle(double radius)
            {
                return Math.PI * radius * radius;
            }
            public double Traingle(double base1,double height)
            {
                return base1 * height;
            }
            public double Square(double side)
            {
                return side * side;
            }
        }
    
}
