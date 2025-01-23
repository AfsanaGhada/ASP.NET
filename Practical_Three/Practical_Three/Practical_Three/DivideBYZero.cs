using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Three
{
    internal class DivideBYZero
    {
        public void DicvideBYZero()
        {
            try
            {
                int a = 100;
                int b = 0;
                int result = a / b;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error Caught....");
            }
            finally {
                Console.WriteLine("Program Finlay Complted.....");
            }
        }
    }
}
