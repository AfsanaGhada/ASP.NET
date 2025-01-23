namespace LAB_4
{
    public class AreaCalculator
    {
        public int Area(int side)
        {
            return side * side; // Area of square
        }

        public int Area(int length, int breadth)
        {
            return length * breadth; // Area of rectangle
        }
    }
}
