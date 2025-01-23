using System;
namespace Lab_3
{
    public class Replacechar_demo
    {
        public void Replace1()
        {
            string input = "Hello World!";
            string result = "";

            foreach (char c in input)
            {
                if (char.IsLower(c))
                    result += char.ToUpper(c);
                else if (char.IsUpper(c))
                    result += char.ToLower(c);
                else
                    result += c;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
