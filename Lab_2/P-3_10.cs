using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Console.ReadLine()[0]; // Read the first character

        if (char.IsLower(ch))
        {
            Console.WriteLine("The character in uppercase: " + char.ToUpper(ch));
        }
        else if (char.IsUpper(ch))
        {
            Console.WriteLine("The character in lowercase: " + char.ToLower(ch));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a letter.");
        }
    }
}
