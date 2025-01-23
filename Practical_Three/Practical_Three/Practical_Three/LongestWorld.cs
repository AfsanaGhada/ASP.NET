using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Three
{
    internal class LongestWorld
    {
        public void lonfff()
        {
                Console.Write("Enter a sentence: ");
                string sentence = Console.ReadLine();

                string[] words = sentence.Split(' ');

                string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();

                Console.WriteLine("The longest word is: " + longestWord);

                Console.ReadLine();

        }
    }
}
