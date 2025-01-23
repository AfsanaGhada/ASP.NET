using System;
using Lab_3;
using LAB_3;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select a program to execute (1-10) or 0 to exit:");
                Console.WriteLine("1. divide by zero exception and handle");
                Console.WriteLine("2. IndexOutOfRange Exception");
                Console.WriteLine("3. abstract class Sum");
                Console.WriteLine("4. create interface Calculate");
                Console.WriteLine("5. common methods of String class");
                Console.WriteLine("6. Replace lower case characters to upper case and Vice-versa");
                Console.WriteLine("7.  create interface ");
                Console.WriteLine("8.  throw an exception if the number is not an even number");
                Console.WriteLine("9.  find the longest word in a string");
                Console.WriteLine("10. change the case of entered character");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Exiting the program.");
                        break;

                    case 1:
                        pr_1_devidebyzeroexe pr_1= new pr_1_devidebyzeroexe();
                        pr_1.DevideByZeroExeption_meth();
                    break;
                    case 2:
                        IndexOutOfRange_Exception ioe= new IndexOutOfRange_Exception();
                        ioe.IndexOutOfRange();
                    break;

                    case 3:
                            Calculate1 calc = new Calculate1();
                                Console.WriteLine("Sum of 2 numbers: " + calc.SumOfTwo(5, 10));
                                Console.WriteLine("Sum of 3 numbers: " + calc.SumOfThree(5, 10, 15));
 
                        break;

                    case 4:
                       
                            Result1 result = new Result1();
                                Console.WriteLine("Addition: " + result.Addition(5, 3));
                                Console.WriteLine("Subtraction: " + result.Subtraction(5, 3));
                    
                        break;

                    case 5:
                        stringdemo.String_method();
                        break;

                    case 6:
                             Replacechar_demo replace= new Replacechar_demo();
                        replace.Replace1();
                        break;
                     case 7:
                        Geometry geometry = new Geometry();
                        Console.WriteLine("Area of Circle: " + geometry.Circle(5));
                        Console.WriteLine("Area of Triangle: " + geometry.Triangle(5, 10));
                        Console.WriteLine("Area of Square: " + geometry.Square(4));

                     break;
                    case 8:
                        Throw_Demo.throwExeption();
                        break;
                    case 9:
                        Program1.longestword();
                        break;
                    case 10:
                        CharcterCheck cc = new CharcterCheck();
                        cc.Check();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
       
    }

}
