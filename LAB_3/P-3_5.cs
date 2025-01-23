using System;
namespace Lab_3
{
    public class stringdemo
    {
        public static void String_method()
        {
            string text = "Hello, World!";
            Console.WriteLine("Length: " + text.Length);
            Console.WriteLine("ToUpper: " + text.ToUpper());
            Console.WriteLine("ToLower: " + text.ToLower());
            Console.WriteLine("Substring: " + text.Substring(0, 5));
            Console.WriteLine("Replace: " + text.Replace("World", "C#"));
        }
    }
}