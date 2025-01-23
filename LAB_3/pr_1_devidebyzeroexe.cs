using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    public class pr_1_devidebyzeroexe
    {
        public void DevideByZeroExeption_meth()
        {
            try
            {
                int a = 20;
                int b = 0;
                int result = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("number Cannot divide by zero.");
            }
        }
    }
}
