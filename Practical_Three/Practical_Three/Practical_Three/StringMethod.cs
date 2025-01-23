using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practical_Three
{
    internal class StringMethod
    {
        string a = "HELLO WORLD";
        string b = "Ghada Afsana";

        public void StringFun()
        {
            Console.WriteLine("ToUpper:" + a.ToUpper());
            Console.WriteLine("ToLower:" + a.ToLower());
            Console.WriteLine("Contains:" + a.Contains("Hey"));
            Console.WriteLine("StartWith:" + a.StartsWith("HELLO"));
            Console.WriteLine("EndWith:" + a.EndsWith("Right"));
            Console.WriteLine("Substring:" + a.Substring(5));
            Console.WriteLine("IndexOF:" + a.IndexOf("ii"));
            Console.WriteLine("Concat" + a.Concat(a.Concat(b)));
            Console.WriteLine("Replace:" + a.Replace("Good", "Excellent"));

        }
    }
}
