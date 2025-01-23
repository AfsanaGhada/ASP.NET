using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Three
{
    internal class InterCalculate
    {
        public interface CalculateOne
        {
            public int Addition(int a, int b);
            public int Substraction(int a, int b);
        }

        public class Result : CalculateOne
        {
            public int Addition(int a,int b)
            {
                return a + b;
            }
            public int Substraction(int a, int b)
            {
                return a - b;
            }

        }
    }
}
