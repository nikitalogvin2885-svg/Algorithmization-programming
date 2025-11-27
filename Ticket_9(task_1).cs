using System;
using System.Collections.Generic;

// Базовый класс Account
public abstract class Account
{
    public string AccountNumber { get; }
    public decimal Balance { get; protected set; }
    public List<string> TransactionHistory { get; }

    protected Account(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        TransactionHistory = new List<string>();
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма депозита должна быть положительной.");

        Balance += amount;
        TransactionHistory.Add($"Дата: {DateTime.Now}, Депозит: +{amount}, Баланс: {Balance}");
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма снятия должна быть положительной.");
        if (Balance < amount)
            throw new InvalidOperationException("Недостаточно средств.");

        Balance -= amount;
        TransactionHistory.Add($"Дата: {DateTime.Now}, Снятие: -{amount}, Баланс: {Balance}");
    }

    public virtual void Transfer(Account recipient, decimal amount)
    {
        if (recipient == null)
            throw new ArgumentNullException(nameof(recipient));
        if (amount <= 0)
            throw new ArgumentException("Сумма перевода должна быть положительной.");
        if (Balance < amount)
            throw new InvalidOperationException("Недостаточно средств.");

        Balance -= amount;
        recipient.Balance += amount;

        TransactionHistory.Add($"Дата: {DateTime.Now}, Перевод: -{amount}, Баланс: {Balance}");
        recipient.TransactionHistory.Add($"Дата: {DateTime.Now}, Поступление: +{amount}, Баланс: {recipient.Balance}");
    }

    public virtual string GetStatement()
    {
        return $"Номер счета: {AccountNumber}\nБаланс: {Balance}\n-----------История транзакций-----------\n{string.Join("\n", TransactionHistory)}";
    }
}

// Сберегательный счет
public class SavingsAccount : Account
{
    public decimal InterestRate { get; }

    public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
        : base(accountNumber, initialBalance)
    {
        InterestRate = interestRate;
    }

    public void CalculateInterest()
    {
        decimal interest = Balance * InterestRate / 100;
        Balance += interest;
        TransactionHistory.Add($"Дата: {DateTime.Now}, Начислены проценты: +{interest}, Баланс: {Balance}");
    }
}

// Расчетный счет
public class CheckingAccount : Account
{
    public CheckingAccount(string accountNumber, decimal initialBalance)
        : base(accountNumber, initialBalance) { }

    public override void Transfer(Account recipient, decimal amount)
    {
        base.Transfer(recipient, amount);
    }
}

// Кредитный счет
public class CreditAccount : Account
{
    public decimal CreditLimit { get; }
    public decimal WithdrawalFee { get; }

    public CreditAccount(string accountNumber, decimal initialBalance, decimal creditLimit, decimal withdrawalFee)
        : base(accountNumber, initialBalance)
    {
        CreditLimit = creditLimit;
        WithdrawalFee = withdrawalFee;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма снятия должна быть положительной.");
        if (Balance + CreditLimit < amount)
            throw new InvalidOperationException("Превышен кредитный лимит.");

        Balance -= amount + WithdrawalFee;
        TransactionHistory.Add($"Дата: {DateTime.Now}, Снятие: -{amount}, Комиссия: -{WithdrawalFee}, Баланс: {Balance}");
    }
}

// Тестирование
class Program
{
    static void Main()
    {
        var savings = new SavingsAccount("235458725", 1500, 5);
        var checking = new CheckingAccount("453378432", 700);
        var credit = new CreditAccount("571484927", 0, 500, 10);

        savings.Deposit(200);
        savings.CalculateInterest();
        Console.WriteLine("Сберегательный счет:");
        Console.WriteLine(savings.GetStatement());
        Console.WriteLine();

        checking.Transfer(savings, 100);
        Console.WriteLine("Расчетный счет:");
        Console.WriteLine(checking.GetStatement());
        Console.WriteLine();

        credit.Withdraw(500);
        Console.WriteLine("Кредитный счет:");
        Console.WriteLine(credit.GetStatement());
    }
}
