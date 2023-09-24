using System;
public class BankAccount
{
    protected string ID;
    protected string Owner;
    protected decimal _Balance;
    public BankAccount(string ID,string Owner)
    {
        this.ID = ID; 
        this.Owner = Owner; 
        this._Balance = 0;
    }
    public void Deposit(decimal Amount)
    {
        _Balance += Amount;
    }
    public void Withdraw(decimal Amount)
    {
        _Balance -= Amount;
    }
    public decimal Balance
    {
        get { return _Balance; }
    }
}

class Program
{   
    static void Main(string[] args)
    {
        BankAccount myAcct = new BankAccount("100120023003", "Nguyen Van An");
        myAcct.Deposit(1000);
        myAcct.Withdraw(100);
        Console.WriteLine("Balance: " + myAcct.Balance);
        Console.ReadLine();
    }
}
