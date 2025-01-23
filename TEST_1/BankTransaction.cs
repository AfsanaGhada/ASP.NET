namespace TEST_1
{
    public class BankTransaction
    {

   
            public string AccountHolderName { get; private set; }
            public double Balance { get; private set; }

            public BankTransaction(string accountHolderName, double initialBalance)
            {
                AccountHolderName = accountHolderName;
                Balance = initialBalance;
            }

            public void Deposit(double amount)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount} cash. New balance: {Balance}");
            }

            public void Deposit(double amount, int checkNumber)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount} via check {checkNumber}. New balance: {Balance}");
            }

            public void Deposit(double amount, string CardNo)
            {
                if (amount > Balance)
                {
                    Console.WriteLine("Insufficient balance.");
                }
                else
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrew {amount} using ATM card {CardNo}. Remaining balance: {Balance}");
                }
            }
        }
    }

