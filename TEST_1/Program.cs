
namespace TEST_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select a program to execute (1-7) or 0 to exit:");
                Console.WriteLine("1. Product Details");
                Console.WriteLine("2. BankTransaction Detail");
                Console.WriteLine("3. vehical  ");
                Console.WriteLine("4. Student Details");
                Console.WriteLine("5. Matrix");
                Console.WriteLine("6. Anagram");
                Console.WriteLine("7. ArmStrong");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Exiting the program.");
                        break;

                    case 1:
                        Product p1 = new Product(1, "apple", 100);
                        p1.DisplayProductDetail();

                        break;
                    case 2:
                        BankTransaction B1 = new BankTransaction("afsana", 10000);
                        B1.Deposit(5000);
                        B1.Deposit(2000, 101);
                        B1.Deposit(2000, "10");

                        break;
                    case 3:
                        Vahicle v;
                        v = new Car();
                        v.Start();
                        v.Stop();
                        break;
                    case 4:
                        Dictionary_data d1 = new Dictionary_data();
                        d1.distionay();
                        break; ;
                    case 5:
                        mat ma = new mat();
                        ma.get();
                        ma.diag();
                        Console.Read();
                        break;
                    case 6:
                        Anagram anagram = new Anagram();
                        string s1 = "geeks";
                        string s2 = "kseeg";
                        Console.WriteLine(anagram.AreAnagrams(s1, s2) ? "true" : "false");
                        break;
                    case 7:
                        Armstrong armstrong = new Armstrong();
                        armstrong.armstrong();
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
