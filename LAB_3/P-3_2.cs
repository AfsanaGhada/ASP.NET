using System;
namespace LAB_3
{ 
class IndexOutOfRange_Exception
{
    public void IndexOutOfRange()
    {
        int[] numbers = new int[5];
        try
        {
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(numbers[10]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Invalid index! You are trying to access an element outside the array.");
        }
    }
}
}