namespace LAB_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select a program to execute (1-10) or 0 to exit:");
                Console.WriteLine("1. Enter 1 to execute first program");
                Console.WriteLine("2. Enter 2 to execute second program");
                Console.WriteLine("3. Enter 3 to execute third program");
                Console.WriteLine("4. Enter 4 to Execute forth program");
                Console.WriteLine("5. Enter 5 to execute fifth program");
                Console.WriteLine("6. Enter 6 to execute sixth program");
               
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Exiting the program.");
                        break;

                    case 1:
                        Addition addition = new Addition();
                        Console.WriteLine("Addition of two integers: " + addition.Add(5, 10));
                        Console.WriteLine("Addition of two floats: " + addition.Add(5.5f, 10.2f));
                        break;
                    case 2:
                        AreaCalculator calculator = new AreaCalculator();
                        Console.WriteLine("Area of square: " + calculator.Area(5));
                        Console.WriteLine("Area of rectangle: " + calculator.Area(5, 10));
                        break;

                    case 3:
                        RBI bank;

                        bank = new HDFC();
                        bank.CalculateInterest();

                        bank = new SBI();
                        bank.CalculateInterest();

                        bank = new ICICI();
                        bank.CalculateInterest();
                        break;
                    case 4:
                        Hospital hospital;

                        hospital = new Apollo();
                        hospital.HospitalDetails();

                        hospital = new Wockhardt();
                        hospital.HospitalDetails();

                        hospital = new Gokul_Superspeciality();
                        hospital.HospitalDetails();
                        break;
                    case 5:
                        Shape shape = new Shape();
                        Console.WriteLine("Area of square: " + shape.Area(5));
                        Console.WriteLine("Area of rectangle: " + shape.Area(5, 10));
                        Console.WriteLine("Area of circle: " + shape.Area(7.5));
                        break;

                    case 6:
                        BankAccount account = new BankAccount("Ghada afsana", 1000);

                        account.Deposit(500);
                        account.Deposit(200, "CHK123");

                        account.Withdraw(300);
                        account.Withdraw(700, "ATM456");
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
