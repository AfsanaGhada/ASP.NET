namespace LAB_4
{
    public class Shape
    {
        public double Area(int side)
        {
            return side * side; // Area of square
        }

        public double Area(int length, int breadth)
        {
            return length * breadth; // Area of rectangle
        }

        public double Area(double radius)
        {
            return Math.PI * radius * radius; // Area of circle
        }
    }
}
