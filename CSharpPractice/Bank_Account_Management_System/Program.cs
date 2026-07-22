using System;

class BankAccount
{
    private int accountNumber;
    private string accountHolderName;
    private double balance;

    private static int totalAccounts = 0;

    public BankAccount(int accountNumber, string accountHolderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.balance = balance;

        totalAccounts++;
    }

    public void Deposit(double amount)
    {
        try
        {
            if (amount <= 0)
            {
                throw new Exception("Deposit amount must be positive.");
            }

            balance += amount;
            Console.WriteLine($"₹{amount} deposited successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Withdraw(double amount)
    {
        try
        {
            if (amount <= 0)
            {
                throw new Exception("Withdrawal amount must be positive.");
            }

            if (amount > balance)
            {
                throw new Exception("Insufficient balance.");
            }

            balance -= amount;
            Console.WriteLine($"₹{amount} withdrawn successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Account Number : {accountNumber}");
        Console.WriteLine($"Account Holder : {accountHolderName}");
        Console.WriteLine($"Balance : ₹{balance}");
    }

    public static void TotalAccounts()
    {
        Console.WriteLine($"Total Accounts Created : {totalAccounts}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount(101, "Sarthak", 10000);

        account1.CheckBalance();

        account1.Deposit(5000);

        account1.Withdraw(3000);

        account1.Withdraw(20000);

        account1.Deposit(-100);

        account1.CheckBalance();

        BankAccount account2 = new BankAccount(102, "Rahul", 5000);

        BankAccount.TotalAccounts();
    }
}