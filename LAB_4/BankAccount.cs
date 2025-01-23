namespace LAB_4
{
    class BankAccount
    {
        public string AccountHolderName { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(string accountHolderName, double initialBalance)
        {
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} cash. New balance: {Balance}");
        }

        public void Deposit(double amount, string checkNumber)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} via check {checkNumber}. New balance: {Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. Remaining balance: {Balance}");
            }
        }

        public void Withdraw(double amount, string atmCard)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount} using ATM card {atmCard}. Remaining balance: {Balance}");
            }
        }
    }
}
