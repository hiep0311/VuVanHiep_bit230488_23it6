using System;

public class NegativeAmountException : Exception
{
    public NegativeAmountException(string message) : base(message)
    {
    }
}

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}

public class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Deposit amount cannot be negative.");
        }
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Withdrawal amount cannot be negative.");
        }
        if (amount > balance)
        {
            throw new InsufficientFundsException("Insufficient funds in the account.");
        }
        balance -= amount;
    }
}

public class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount();

        try
        {
            account.Deposit(1000.0m);
            Console.WriteLine($"Deposited $1000.00. Current balance: ${account.Balance:0.00}");

            account.Withdraw(500.0m);
            Console.WriteLine($"Withdrew $500.00. Current balance: ${account.Balance:0.00}");

            account.Withdraw(600.0m);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NegativeAmountException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}