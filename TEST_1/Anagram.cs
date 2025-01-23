using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_1
{
    internal class Anagram
    {
        public bool AreAnagrams(string s1, string s2)
        {

            // Sort both strings
            char[] s1Array = s1.ToCharArray();
            char[] s2Array = s2.ToCharArray();
            Array.Sort(s1Array);
            Array.Sort(s2Array);

            // Compare sorted strings
            return new string(s1Array) == new string(s2Array);
        }
        
    }
}




  
