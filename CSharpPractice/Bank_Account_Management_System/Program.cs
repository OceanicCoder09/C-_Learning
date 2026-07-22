using System;

class BankAccount
{
    public int AccountNumber;
    public string AccountHolderName;
    private double Balance;

    public BankAccount(int AccountNumber, string AccountHolderName, double Balance)
    {
        this.AccountNumber = AccountNumber;
        this.AccountHolderName = AccountHolderName;
        this.Balance = Balance;
    }
    public void Deposit(double amount)
    {
        if(amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    public void withDraw(double amount)
    {
        if(amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew: {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: {Balance}");
    }
}

class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount(123456, "Sarthak", 1000.0);

        account.CheckBalance();

        account.Deposit(500.0);

        account.withDraw(200.0);

        account.CheckBalance();

    }
}