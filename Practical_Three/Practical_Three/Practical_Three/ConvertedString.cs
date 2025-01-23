using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Three
{
    internal class ConvertedString
    {
        public void ConStrinf()
        {
            Console.WriteLine("Enter String:");
            char uservalue = Convert.ToChar(Console.Read());


            if (char.IsLower(uservalue))
            {
                Console.WriteLine(char.ToUpper(uservalue));
            }
            else if (char.IsUpper(uservalue))
            {
                Console.WriteLine(char.ToLower(uservalue));
            }
            else
            {
                Console.WriteLine(uservalue);
            }
            }
    }
}
