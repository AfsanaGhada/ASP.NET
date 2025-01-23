using System;
namespace LAB_3
{
    public class Program1
    {
        public static void longestword()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

             
            string[] words = input.Split(' ');

            
            string longestWord = "";

            
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine("The longest word is: " + longestWord);
        }
    }
}