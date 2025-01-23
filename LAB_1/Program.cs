using System;

namespace LAB_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter program no do you check Logic:");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter you name:");
                    string name=Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter you Address:");
                    string Address = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter you City:");
                    string City = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter you Contect_num:");
                    int Contect_num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your name is:"+name);
                    Console.WriteLine("Your Address is:"+Address);

                    Console.WriteLine("Your Contect num is:"+Contect_num);
                    Console.WriteLine("Your City is:"+City);


                 break;

                    case 2:
                        Console.WriteLine("Enter number 1:");
                        int a=Convert.ToInt32(Console.ReadLine());  
                        Console.WriteLine("Enter number 2:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("number 1 is:"+a);
                        Console.WriteLine("number 2 is:" + b);


                    break;

                    case 3:
                    Console.WriteLine("Enter you name:");
                    string name1 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter you City:");
                    string City1 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine($"Hello {name1} from country {City1}.");


                    break;
                    case 4:
                        Console.WriteLine("Enter Length:");
                        int Length=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Width:");
                        int Width = Convert.ToInt32(Console.ReadLine());

                    double area = Length * Width;
                    Console.WriteLine("Area of Square feet is:"+area);
                        
                    break;

                    case 5:
                    Console.WriteLine("Check Area of Circle");

                    Console.WriteLine("Enter Radius:");
                    int r = Convert.ToInt32(Console.ReadLine());

                    double pi = 3.14;
                    double  Circle = pi * r * r;
                    Console.WriteLine("Area of Circle is:" + Circle);

                    Console.WriteLine("Check Area of Square");
                    Console.WriteLine("Enter area:");
                    int area1 = Convert.ToInt32(Console.ReadLine());
                    double Area2 = area1 * area1;
                    Console.WriteLine("Area of square is:"+Area2);

                    Console.WriteLine("Check Area of Rectange ");
                    Console.WriteLine("Enter Length:");
                    int Length1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Width:");
                    int Width1 = Convert.ToInt32(Console.ReadLine());

                    double Rectange = Length1 * Width1;
                    Console.WriteLine("Area of Square feet is:" + Rectange);



                    break;
                case 6:
                    Console.WriteLine("celcuis to Fehrenheit");

                    double CelToFahren(double celsius)
                    {
                        return (celsius * 9 / 5) + 32;
                    }

                    double FahrenheitToCelsius(double fahrenheit)
                    {
                        return (fahrenheit - 32) * 5 / 9;
                    }

                    Console.Write("Enter temperature in Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Temperature in Fahrenheit: {CelToFahren(celsius)}");

                    Console.Write("Enter temperature in Fahrenheit: ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Temperature in Celsius: {FahrenheitToCelsius(fahrenheit)}");
                    break;
                case 7:

                    double CalculateSI(double p, double r, double t)
                    {
                        return (p * r * t) / 100;
                    }

                    Console.Write("Enter Principal amount: ");
                    double p = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Rate of Interest: ");
                    double r1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Time: ");
                    double t = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"The Simple Interest is: {CalculateSI(p, r1, t)}");

                    break;

                    case 8:
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the operation (+, -, *, /): ");
                    char ope = Convert.ToChar(Console.ReadLine());

                    if (ope == '+')
                        Console.WriteLine($"Result: {num1 + num2}");
                    else if (ope == '-')
                        Console.WriteLine($"Result: {num1 - num2}");
                    else if (ope == '*')
                        Console.WriteLine($"Result: {num1 * num2}");
                    else if (ope == '/')
                        Console.WriteLine($"Result: {num1 / num2}");
                    else
                        Console.WriteLine("Invalid operation");

                    break;

                case 9:
                    int x = 10;
                    int y = 20;

                    x = x + y;
                    y = x - y;
                    x = x - y;

                    Console.WriteLine($"After Swaping x is {x} and y is {y}. ");

                break;

                case 10:
                    Console.WriteLine("Enter first number:");
                    double number1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter third number:");
                    double number3 = Convert.ToDouble(Console.ReadLine());

                    double max = (number1 > number2)
                                 ? (number1 > number3 ? number1 : number3)
                                 : (number2 > number3 ? number2 : number3);

                    Console.WriteLine("The maximum number is: " + max);

                    break;


            }
        }
    }
}
