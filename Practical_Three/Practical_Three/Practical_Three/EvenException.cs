using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Three
{
    public class EvenNumberException : Exception
    {
        public EvenNumberException() : base("Input number is not even.") { }
    }

    public class EvenNumberChecker
    {
        public void CheckEvenNumber(int number)
        {
            if (number % 2 != 0)
            {
                throw new EvenNumberException();
            }
            else
            {
                Console.WriteLine("The number is even.");
            }
        }
    }
}
