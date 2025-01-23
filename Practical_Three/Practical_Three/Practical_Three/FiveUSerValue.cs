using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Three
{
    internal class FiveUSerValue
    {
        public void FiveUserValue()
        {
            int[] numbers = new int[5];

            try
            {
                Console.WriteLine("Enter 5 numbers:");

                for (int i = 0; i <= 5; i++)
                {
                    Console.Write("Enter number {0}: ", i + 1);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Invalid array index.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }

            Console.ReadLine();
        }
        
    }
}
