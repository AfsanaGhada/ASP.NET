using System;
namespace LAB_3
{
    public interface Shape
    {
        double Circle(double radius);
        double Triangle(double baseLength, double height);
        double Square(double side);
    }

    public class Geometry : Shape
    {
        public double Circle(double radius)
        {
            return 3.14 * radius * radius;
        }

        public double Triangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double Square(double side)
        {
            return side * side;
        }
    }
}

        
