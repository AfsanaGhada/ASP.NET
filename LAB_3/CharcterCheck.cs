using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class CharcterCheck
    {
        public void Check()
        {
            Console.Write("Enter a character: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsLower(character))
            {
                char upperCase = char.ToUpper(character);
                Console.WriteLine("Uppercase: " + upperCase);
            }
            else if (char.IsUpper(character))
            {
                char lowerCase = char.ToLower(character);
                Console.WriteLine("Lowercase: " + lowerCase);
            }
            else
            {
                Console.WriteLine("Character is not an alphabet.");
            }
        }
    }
}
