using System;
namespace Lab_3
{
    public class Throw_Demo
    {
        public static void throwExeption()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 != 0)
                {
                    throw new Exception("The number is not even.");
                }

                Console.WriteLine("The number is even.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}